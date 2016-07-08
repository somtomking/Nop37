use nop37
if  not exists (select Name From SysColumns Where ID = OBJECT_ID('Vendor') And Name = 'VendorTypeId')
--向供应商表添加供应商类型字段 2016-07-08
ALTER TABLE Vendor ADD  VendorTypeId int default(0) not null;
GO