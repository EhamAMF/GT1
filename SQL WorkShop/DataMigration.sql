
Select
s.StockID 
,s.AmountLeft 
,s.ExDate 
,s.ProductID 
,p.AlertAmount
,p.Barcode 
,p.BarcodeInt 
,p.IsCustomBarcode 
,p.PacketCost 
,p.PacketSellPrice 
,p.ProductName 
,p.SellPrice 
,p.SubAmount 
,p.UnitCost 

into #TempAllStock

from GT_Dis.dbo.Stock s
left join GT_Dis.dbo.Product p on p.ProductID = s.ProductID
where s.StockID in (Select StockID  from GT_Dis.dbo.Invoice_prd)




DECLARE @InvoiceID bigint
DECLARE @InvoiceTypeID bigint = 7
DECLARE @InvoiceTypeName nvarchar(200)
DECLARE @IsPaid bit =1
DECLARE @InvoiceNumber bigint =1
DECLARE @InvoiceRealNumber nvarchar(200)
DECLARE @OrgInvoiceID bigint
DECLARE @OrgInvoiceNumber bigint
DECLARE @InvDate datetime = getdate()
DECLARE @AgentID bigint 
DECLARE @AgentName nvarchar(200)
DECLARE @DistributorID bigint
DECLARE @DistributorName nvarchar(200)
DECLARE @CustomerName nvarchar(200)
DECLARE @TotalPrice decimal(18,3) = 1
DECLARE @FinalPrice decimal(18,3) = 1
DECLARE @Revenue decimal(18,3) = 1
DECLARE @Note nvarchar(200) = 'ÑÕíÏ ãÑÍá ãä ÇáãäÙæãÉ ÇáÞÏíãÉ'
DECLARE @UserID bigint =1
DECLARE @Username nvarchar(50)

-- TODO: Set parameter values here.

EXECUTE  [GT1].[dbo].[sp_tbl_Invoice_Insert] 
   @InvoiceID OUTPUT
  ,@InvoiceTypeID
  ,@InvoiceTypeName OUTPUT
  ,@IsPaid
  ,@InvoiceNumber
  ,@InvoiceRealNumber
  ,@OrgInvoiceID
  ,@OrgInvoiceNumber OUTPUT
  ,@InvDate
  ,@AgentID
  ,@AgentName OUTPUT
  ,@DistributorID
  ,@DistributorName OUTPUT
  ,@CustomerName
  ,@TotalPrice
  ,@FinalPrice
  ,@Revenue
  ,@Note
  ,@UserID
  ,@Username OUTPUT








DECLARE @Gt1StockID bigint
DECLARE @GT1ProductID bigint
DECLARE @ProductName nvarchar(200)
DECLARE @ExDate datetime
DECLARE @SellPrice decimal(18,3)
DECLARE @SellPricePacket decimal(18,3)
DECLARE @Barcode nvarchar(200)
DECLARE @ProductCode nvarchar(200)
DECLARE @ProductDetails nvarchar(200)
DECLARE @TypeID bigint
DECLARE @TypeName nvarchar(200)
DECLARE @BrandID bigint
DECLARE @BrandName nvarchar(200)
DECLARE @Rack nvarchar(200)
DECLARE @AlertAmount decimal(18,3)
DECLARE @AlertAmountPacket decimal(18,3)
DECLARE @SubAmount int

DECLARE @IsExpress bit 
DECLARE @IsMultiExDateAllowed bit  

declare @AmountLeft Decimal(18,3)
declare @UnitCost Decimal(18,3)
declare @PacketCost Decimal(18,3)



declare @n int = 1
Declare @ID bigint
While (Select Count(*) From #TempAllStock) > 0
	Begin

		Select Top 1 @ID = s.StockID 			
			,@AmountLeft = s.AmountLeft 
			,@ExDate=s.ExDate
			,@AlertAmount=s.AlertAmount
			,@Barcode=s.Barcode 
			,@PacketCost = s.PacketCost 
			,@SellPricePacket=s.PacketSellPrice 
			,@ProductName = s.ProductName 
			,@SellPrice=s.SellPrice 
			,@SubAmount=s.SubAmount 
			,@UnitCost=s.UnitCost 
			
			,@ProductCode = ''
			,@ProductDetails = ''
			,@TypeID = null
			,@TypeName = null
			,@BrandID = null
			,@BrandName = null
			,@Rack = ''		
			,@UserID = 1
			,@Username = ''
			,@IsExpress = 1
			,@IsMultiExDateAllowed = 0		
			
			
		
			
										
			From #TempAllStock s

			
			set @Gt1StockID = null
			set @GT1ProductID = null
			
			EXECUTE [GT1].[dbo].[sp_tbl_ProductStock_Insert] 
			   @Gt1StockID OUTPUT
			  ,@gt1ProductID
			  ,@ProductName
			  ,@ExDate
			  ,@SellPrice
			  ,@SellPricePacket
			  ,@Barcode OUTPUT
			  ,@ProductCode
			  ,@ProductDetails
			  ,@TypeID
			  ,@TypeName OUTPUT
			  ,@BrandID
			  ,@BrandName OUTPUT
			  ,@Rack
			  ,@AlertAmount
			  ,@AlertAmountPacket
			  ,@SubAmount
			  ,@UserID
			  ,@Username OUTPUT
			  ,@IsExpress
			  ,@IsMultiExDateAllowed
			  


				
				DECLARE @InvPrdID bigint
								
				DECLARE @Sort int = @n
				DECLARE @WareHouseID bigint 
				DECLARE @PlusOrMinus int = 1
				DECLARE @StockID bigint = @Gt1StockID
				DECLARE @ProductID bigint = @gt1ProductID
				DECLARE @IsPacket bit = 0
				DECLARE @Amount decimal(18,3)  = @AmountLeft
				DECLARE @UnitPrice decimal(18,3) = @UnitCost
				DECLARE @AvgCost decimal(18,3) = @UnitCost
				DECLARE @AmountPacket decimal(18,3)
				DECLARE @UnitPricePacket decimal(18,3)
				DECLARE @AvgCostPacket decimal(18,3)
				DECLARE @Amount_inv decimal(18,3)  = @AmountLeft
				DECLARE @UnitPrice_inv decimal(18,3)  = @UnitCost
				DECLARE @AvgCost_inv decimal(18,3) = @UnitCost
				DECLARE @Total decimal(18,3) = @AmountLeft * @UnitCost
				DECLARE @TotalCost decimal(18,3) =  @AmountLeft * @UnitCost
				DECLARE @InvPrdRevenue decimal(18,3) = 0

				
				if @SubAmount is null or @SubAmount <=1 
				begin
				set @AmountPacket = null
				set @UnitPricePacket = null
				set @AvgCostPacket = null
				end
				else
				begin
				set @AmountPacket = @Amount / @SubAmount 
				set @UnitPricePacket = @UnitPrice * @SubAmount 
				set @AvgCostPacket = @UnitPricePacket
				end
				
				if @AmountLeft >0
				begin				

				EXECUTE  [GT1].[dbo].[sp_tbl_Invoice_prd_Insert] 
				@InvPrdID OUTPUT
				,@InvoiceID
				,@InvoiceTypeID OUTPUT
				,@Sort
				,@WareHouseID
				,@PlusOrMinus
				,@StockID
				,@ProductID OUTPUT
				,@IsPacket
				,@Amount
				,@UnitPrice
				,@AvgCost
				,@AmountPacket
				,@UnitPricePacket
				,@AvgCostPacket
				,@Amount_inv
				,@UnitPrice_inv
				,@AvgCost_inv
				,@Total
				,@TotalCost
				,@InvPrdRevenue	
				
				end
		
		Delete #TempAllStock Where StockID = @Id
		
		Set @n = @n +1

	End

declare @T decimal(18,3) =(Select SUM(ip.Total) from Invoice_prd ip where ip.InvoiceID = @InvoiceID)
update Invoice 
set TotalPrice = @t
,FinalPrice = @t
where InvoiceID = @InvoiceID 

exec GT1.dbo.sp_op_ProcessAll


select
a.AgentID
,a.AgentName 
,a.Phone
,a.Address
,GT_Dis.DBO.fn_AgentCredit_ByDis(a.AgentID ,null ,null ,null) -  GT_Dis.DBO.fn_AgentDebit_ByDis(a.AgentID  ,null ,null ,null ) AS Balance
Into   #Temp
from GT_Dis.dbo.Agent a
where a.AgentID <> 1 
order by a.AgentID 




DECLARE @Phone nvarchar(200)
DECLARE @address nvarchar(200)

DECLARE @IniBalanceDebit decimal(18,3)
DECLARE @IniBalanceCredit decimal(18,3)
DECLARE @IniBalance decimal(18,3)







While (Select Count(*) From #Temp) > 0
	Begin

		Select Top 1 
		@ID = AgentID 		
		,@AgentName = AgentName 
		,@Phone = @Phone 
		,@address = Address
		,@Note = null
		,@IniBalanceDebit = case when Balance < 0 then ABS(Balance) else 0 end
		,@IniBalanceCredit = case when Balance > 0 then ABS(Balance) else 0 end
		,@IniBalance = null
		,@UserID = 1
		,@Username = null		
		From #Temp order by AgentID
		
		-- TODO: Set parameter values here.
set @AgentID = null
EXECUTE [GT1].[dbo].[sp_tbl_Agent_Insert] 
   @AgentID OUTPUT
  ,@AgentName
  ,@Phone
  ,@address
  ,@Note
  ,@IniBalanceDebit
  ,@IniBalanceCredit
  ,@IniBalance OUTPUT
  ,@UserID
  ,@Username OUTPUT
		
		
		Delete #Temp Where AgentID  = @Id

	End



