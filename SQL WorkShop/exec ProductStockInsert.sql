
DECLARE @StockID bigint =11
DECLARE @ProductID bigint =10
DECLARE @ProductName nvarchar(200) = 'xxxxx'
DECLARE @ExDate datetime = '2017/1/1'
DECLARE @SellPrice decimal(18,3) = 5
DECLARE @SellPricePacket decimal(18,3) = 25
DECLARE @Barcode nvarchar(200) = null
DECLARE @ProductCode nvarchar(200) ='154244'
DECLARE @ProductDetails nvarchar(200) = 'Details'
DECLARE @TypeID bigint = 1
DECLARE @TypeName nvarchar(200)
DECLARE @BrandID bigint = 1
DECLARE @BrandNamw nvarchar(200)
DECLARE @Rack nvarchar(200) ='a3'
DECLARE @AlertAmount decimal(18,3) = 3
DECLARE @SubAmount int = 5
DECLARE @UserID bigint =1
DECLARE @Username nvarchar(50)

DECLARE @IsExpress bit = 0
DECLARE @IsMultiExDateAllowed bit = 1

-- TODO: Set parameter values here.

EXECUTE  [GT1].[dbo].[sp_tbl_ProductStock_Insert] 
   @StockID OUTPUT
  ,@ProductID
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
  ,@BrandNamw OUTPUT
  ,@Rack
  ,@AlertAmount
  ,@SubAmount
  ,@UserID
  ,@Username OUTPUT
  ,@IsExpress
  ,@IsMultiExDateAllowed



