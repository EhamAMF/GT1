declare
@ItemID bigint =45
,@IsProduct bit = 1
,@Barcode nvarchar(200) = '#100'
,@Org_InvoiceID bigint=2




select
'1.' + CAST (s.StockID as nvarchar(20)) GID
,s.StockID ItemID
,p.ProductName ItemName
,s.ExDate 
,p.Barcode 
,p.ProductCode 
,p.ProductDetails 
,p.SubAmount

, case when @Org_InvoiceID IS null then s.SellPrice 
else (Select ip.UnitPrice  from Invoice_prd ip where ip.InvoiceID = @Org_InvoiceID and ip.StockID =s.StockID )
end
UnitPrice 


,s.SellPricePacket PricePacket
,s.AvgUnitCost 
,s.AvgUnitCostPacket 
 
from Stock s
left join Product p on p.ProductID = s.ProductID 

where 
(@IsProduct = 1  and s.StockID = @ItemID )
or (p.Barcode = @Barcode and @ItemID is null  and (@Org_InvoiceID is null or s.StockID in (Select ip.StockID  from Invoice_prd ip where ip.InvoiceID= @Org_InvoiceID ))  )
