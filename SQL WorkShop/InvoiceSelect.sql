declare

@InvoiceID bigint = 2
,@InvoiceTypeID bigint
,@IsPaid bit
,@InvoiceNumber bigint
,@InvoiceRealNumber nvarchar(200)
,@OrgInvoiceID bigint
,@OrgInvoiceNumber bigint
,@InvDate datetime
,@AgentID bigint
,@DistributorID bigint
,@CustomerName nvarchar(200)
,@TotalPrice decimal(18,3)
,@FinalPrice decimal(18,3)
,@Revenue decimal(18,3)
,@Note nvarchar(200)
,@UserID bigint
,@InvoiceInfo nvarchar(200)
,@AgentName nvarchar(200)
,@DistributorName nvarchar(200)
,@Username nvarchar(200)



select
ip.Sort 
,'1.'+ CAST(ip.StockID as nvarchar(200)) as GID 
,1 IsProduct
,ip.PlusOrMinus 
,ip.StockID ItemID
,p.SubAmount 
,s.SellPricePacket  
,p.ProductName ItemName
,p.ProductDetails ItemDetails
,p.Barcode 
,p.ProductCode 
,ip.Amount 
,ip.UnitPrice
,ip.AvgCost
,ip.Total
,ip.Revenue 


from Invoice_prd ip
left join Stock s on s.StockID = ip.StockID 
left join Product p on p.ProductID = s.ProductID 
where ip.InvoiceID = @InvoiceID

union all

select
isv.Sort 
,'2.'+ CAST(isv.ServiceID  as nvarchar(200)) as GID 
,0 IsProduct
,null PlusOrMinus 
,isv.ServiceID  ItemID
,null SubAmount 
,null SellPricePacket  
,sv.ServiceName  ItemName
,null ItemDetails
,null Barcode 
,null ProductCode 
,isv.Amount 
,ip.UnitPrice
,ip.AvgCost
,ip.Total
,ip.Revenue 

from Invoice_srv isv
left join Service sv on sv.ServiceID = isv.ServiceID 
where isv.InvoiceID = @InvoiceID 