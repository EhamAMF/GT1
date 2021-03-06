USE [GT1]
GO
/****** Object:  StoredProcedure [dbo].[sp_tbl_ProductStock_Insert]    Script Date: 08/03/2016 13:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[sp_tbl_ProductStock_Insert]

@StockID bigint OUT
,@ProductID bigint
,@ProductName nvarchar(200)
,@ExDate datetime
,@SellPrice decimal(18,3)
,@SellPricePacket decimal(18,3)


,@Barcode nvarchar(200) out
,@ProductCode nvarchar(200)
,@ProductDetails nvarchar(200)
,@TypeID bigint
,@TypeName nvarchar(200) OUT
,@BrandID bigint
,@BrandNamw nvarchar(200) OUT
,@Rack nvarchar(200)
,@AlertAmount decimal(18,3)
,@SubAmount int

,@UserID bigint
,@Username nvarchar(50) OUT


,@IsExpress bit
,@IsMultiExDateAllowed bit

as

Declare @ErrorStr as nvarchar (200) 

declare @Status nvarchar(200)

if @StockID is null set @Status ='New Stock New Product'
else if exists (Select * from Stock s where s.ProductID = @ProductID and s.ExDate = @ExDate )
set @Status = 'old Stock old Product'
else set @Status ='New Stock old Product'

if @Status = 'New Stock New Product'
	begin
	
  	EXECUTE [GT1].[dbo].[sp_tbl_Product_Insert] 
   @ProductID   OUTPUT
  ,@ProductName 
  ,@Barcode  OUTPUT
  ,@ProductCode 
  ,@ProductDetails 
  ,@TypeID 
  ,@TypeName OUTPUT
  ,@BrandID 
  ,@BrandNamw OUTPUT
  ,@Rack 
  ,@AlertAmount 
  ,@SubAmount 
  ,@UserID 
  ,@Username OUTPUT
  	EXECUTE [GT1].[dbo].[sp_tbl_Stock_Insert] 
   @StockID OUTPUT
  ,@ProductID
  ,@ProductName OUTPUT
  ,@ExDate
  ,@SellPrice
  ,@SellPricePacket
  ,@UserID
  ,@Username OUTPUT

	
	end
	
	else if @Status = 'New Stock old Product'
	begin
	
	if @IsMultiExDateAllowed = 1
		begin
		
		EXECUTE  [GT1].[dbo].[sp_tbl_Product_Update] 
		   @ProductID
		  ,@ProductName
		  ,@ProductCode
		  ,@ProductDetails
		  ,@TypeID
		  ,@TypeName OUTPUT
		  ,@BrandID
		  ,@BrandNamw OUTPUT
		  ,@Rack
		  ,@UserID
		  ,@Username OUTPUT
  		EXECUTE [GT1].[dbo].[sp_tbl_Stock_Insert] 
		   @StockID OUTPUT
		  ,@ProductID
		  ,@ProductName OUTPUT
		  ,@ExDate
		  ,@SellPrice
		  ,@SellPricePacket
		  ,@UserID
		  ,@Username OUTPUT

		
		end
		
		else
		
		begin
		
			if @IsExpress  = 1
			begin
			EXECUTE  [GT1].[dbo].[sp_tbl_Product_Update] 
		   @ProductID
		  ,@ProductName
		  ,@ProductCode
		  ,@ProductDetails
		  ,@TypeID
		  ,@TypeName OUTPUT
		  ,@BrandID
		  ,@BrandNamw OUTPUT
		  ,@Rack
		  ,@UserID
		  ,@Username OUTPUT
			EXECUTE [GT1].[dbo].[sp_tbl_Stock_Insert] 
		   @StockID OUTPUT
		  ,@ProductID
		  ,@ProductName OUTPUT
		  ,@ExDate
		  ,@SellPrice
		  ,@SellPricePacket
		  ,@UserID
		  ,@Username OUTPUT
			end
			else
			begin
			set @ErrorStr = 'لا يمكن الادخال الصنف موجود !' 
			RaisError (@ErrorStr,11,2)  
			end

		
		
		end
	
	
	end
	else if @Status = 'old Stock old Product'
	begin
	
		if @IsExpress = 1
		begin
		
		EXECUTE  [GT1].[dbo].[sp_tbl_Product_Update] 
		   @ProductID
		  ,@ProductName
		  ,@ProductCode
		  ,@ProductDetails
		  ,@TypeID
		  ,@TypeName OUTPUT
		  ,@BrandID
		  ,@BrandNamw OUTPUT
		  ,@Rack
		  ,@UserID
		  ,@Username OUTPUT
		EXECUTE [GT1].[dbo].[sp_tbl_Stock_Update] 
		   @StockID
		  ,@ProductID
		  ,@ProductName OUTPUT
		  ,@ExDate
		  ,@SellPrice
		  ,@SellPricePacket
		  ,@UserID
		  ,@Username OUTPUT

		end
		else
		begin
		set @ErrorStr = 'لا يمكن الادخال الصنف موجود !' 
		RaisError (@ErrorStr,11,2)  
		End
	
	end
	
	