





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


DECLARE @UserID bigint
DECLARE @Username nvarchar(200)



declare @n int = 1
Declare @ID bigint
While (Select Count(*) From #TempAllStock) > 0
	Begin

		Select Top 1 @ID = s.StockID 			
			,@AmountLeft =  0
			,@ExDate=s.ExDate
			,@AlertAmount=s.AlertAmount
			,@Barcode=s.Barcode 
			,@PacketCost = case when s.SubAmount > 1 then s.UnitCost else null end 
			,@SellPricePacket=case when s.SubAmount > 1 then s.SellPrice else null end   
			,@ProductName = ltrim(rtrim(s.ProductName))
			,@SellPrice= case when s.SubAmount > 1 then s.SellPrice/s.SubAmount  else s.SellPrice end  
			,@SubAmount=s.SubAmount 
			,@UnitCost = case when s.SubAmount > 1 then s.UnitCost /s.SubAmount  else s.UnitCost  end  
			
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
			  


				
				
		
		Delete #TempAllStock Where StockID = @Id
		
		Set @n = @n +1

	End








