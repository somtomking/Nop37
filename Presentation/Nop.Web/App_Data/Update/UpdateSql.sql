use nop37
if  not exists (select Name From SysColumns Where ID = OBJECT_ID('Vendor') And Name = 'VendorTypeId')
--向供应商表添加供应商类型字段 2016-07-08
ALTER TABLE Vendor ADD  VendorTypeId int default(0) not null;
GO


if  not exists (select Name From SysColumns Where ID = OBJECT_ID('ShoppingCartItem') And Name = 'IsBuyNow')
--向购物车里加入是否立即购买字段，这个是用户点击立即购买产生的进行时状态 2016-07-10
ALTER TABLE ShoppingCartItem ADD  IsBuyNow bit default(0) not null;
GO