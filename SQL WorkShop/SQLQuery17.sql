select 
it.InvoiceTypeName 
,ip.CurrentAmount 
,ip.Amount 
,ip.UnitPrice 
,ip.NetPrice
,ip.AvgCost 
--,null as [ ]
--,ip.CurrentAmountPacket 
--,ip.AmountPacket 
--,ip.UnitPricePacket 
--,ip.NetPricePacket 
--,ip.AvgCostPacket 
,null as [ ]
,ip.Amount_inv 
,ip.UnitPrice_inv  
,ip.NetPrice_inv 
,ip.Total 
,ip.TotalCost 
,ip.Revenue  


from Invoice_prd ip
left join Invoice i on i.InvoiceID = ip.InvoiceID 
left join InvoiceType it on it.InvoiceTypeID = i.InvoiceTypeID 
where 
ip.StockID = 48