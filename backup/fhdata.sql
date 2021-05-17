INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6ff8ad40-2604-4492-858f-eae35d7d2dd9', N'power', N'power', N'64f0e24e-8a0c-449e-baee-b40b65af03f5')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'060dc440-4e19-46e8-8fd1-ec3e12d7e91c', N'power@furniturehouse.com', N'POWER@FURNITUREHOUSE.COM', N'power@furniturehouse.com', N'POWER@FURNITUREHOUSE.COM', 0, N'AQAAAAEAACcQAAAAEDZ0UGqkFeFuztrmdjzSTV5f64+z5U6oZecjfPAq8ZUAYp1vb0CPcYsXizJizNZPmw==', N'ZS2FSCALA7KRN2LWMHG4DXSYZIXXHYVG', N'c9b1b02f-d8d3-45dd-aecd-d39775130011', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'3f06ad89-96e8-4f12-a93b-5c2818ccd82c', N'powers@furniturehouse.com', N'POWERS@FURNITUREHOUSE.COM', N'powers@furniturehouse.com', N'POWERS@FURNITUREHOUSE.COM', 1, N'AQAAAAEAACcQAAAAEE5BJUM0clhPAg/Xjr7qwLrgo+B0eE++RP8iCmw1/hCZn+R3/8GJM1+CjlJE9XcMEw==', N'G63HPQZROUO5RMQ4G2HVCZKWGDHSB7IC', N'8d5a5882-8275-467d-890f-63b5350febd8', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fe7c8dde-f8ba-4f1d-bd2e-66957209469f', N'jacob@gmail.com', N'JACOB@GMAIL.COM', N'jacob@gmail.com', N'JACOB@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEAN+jbSu4O/gQKgZvxutvqqEuIcTSySYHrbanhKtLynyUUjjGDOWA4SFxd5RuCXSmA==', N'4SWPC345K3AAA274ORFCYZLTN7EXXVRN', N'24d1a51c-254c-48b0-80e8-4598785e35d1', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3f06ad89-96e8-4f12-a93b-5c2818ccd82c', N'6ff8ad40-2604-4492-858f-eae35d7d2dd9')
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName], [Traits], [Material], [Extension]) VALUES (1, N'Woodsworth', N'Contemporary, Classic, Clean Lines', N'Shessham, Mango, Acacia', N'.jpg')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName], [Traits], [Material], [Extension]) VALUES (2, N'Bohemiana', N'Unconventional, Quirky, Eclectic', N'Mango, Sheesham, Metal', N'.jpg')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName], [Traits], [Material], [Extension]) VALUES (3, N'Durian', N'Luxurious, Affordable, Durable, Plush, Stylish', N'Fabric, Leatherette, Engineered Wood, Mdf And Plywood', N'.jpg')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName], [Traits], [Material], [Extension]) VALUES (4, N'CasaCraft', N'Definitive, Uber Chic, Trendsetting', N'Fabric, Rubber Wood, Ply Wood, Solid Wood', N'.jpg')
GO
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[FurnitureCategories] ON 
GO
INSERT [dbo].[FurnitureCategories] ([FurnitureCategoryID], [FurnitureCategoryName]) VALUES (1, N'Living')
GO
INSERT [dbo].[FurnitureCategories] ([FurnitureCategoryID], [FurnitureCategoryName]) VALUES (2, N'Bedroom')
GO
INSERT [dbo].[FurnitureCategories] ([FurnitureCategoryID], [FurnitureCategoryName]) VALUES (3, N'Kids Room')
GO
SET IDENTITY_INSERT [dbo].[FurnitureCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[FurnitureSubCategories] ON 
GO
INSERT [dbo].[FurnitureSubCategories] ([FurnitureSubCategoryID], [FurnitureSubCategoryName], [FurnitureCategoryID]) VALUES (1, N'Sofas', 1)
GO
INSERT [dbo].[FurnitureSubCategories] ([FurnitureSubCategoryID], [FurnitureSubCategoryName], [FurnitureCategoryID]) VALUES (2, N'Seating', 1)
GO
INSERT [dbo].[FurnitureSubCategories] ([FurnitureSubCategoryID], [FurnitureSubCategoryName], [FurnitureCategoryID]) VALUES (3, N'Decor', 1)
GO
INSERT [dbo].[FurnitureSubCategories] ([FurnitureSubCategoryID], [FurnitureSubCategoryName], [FurnitureCategoryID]) VALUES (4, N'Poster Bed', 2)
GO
INSERT [dbo].[FurnitureSubCategories] ([FurnitureSubCategoryID], [FurnitureSubCategoryName], [FurnitureCategoryID]) VALUES (5, N'Bunk Bed', 2)
GO
INSERT [dbo].[FurnitureSubCategories] ([FurnitureSubCategoryID], [FurnitureSubCategoryName], [FurnitureCategoryID]) VALUES (6, N'Folding Bed', 2)
GO
INSERT [dbo].[FurnitureSubCategories] ([FurnitureSubCategoryID], [FurnitureSubCategoryName], [FurnitureCategoryID]) VALUES (7, N'Cribs', 3)
GO
INSERT [dbo].[FurnitureSubCategories] ([FurnitureSubCategoryID], [FurnitureSubCategoryName], [FurnitureCategoryID]) VALUES (8, N'Study Tables', 3)
GO
INSERT [dbo].[FurnitureSubCategories] ([FurnitureSubCategoryID], [FurnitureSubCategoryName], [FurnitureCategoryID]) VALUES (9, N'Book Shelves', 3)
GO
SET IDENTITY_INSERT [dbo].[FurnitureSubCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[FurnitureInfos] ON 
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (1, N'Miranda 3 Seater Sofa In Navy Blue Colour', 1639.98, 999.98, N'.PNG', 1, 1)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (2, N'Miranda 3 Seater Sofa In Charcoal Grey Colour', 1639.98, 999.98, N'.PNG', 1, 1)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (3, N'Miranda 3 Seater Sofa In Sandy Brown Colour', 1639.98, 999.98, N'.PNG', 1, 1)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (4, N'Diego 2 Seater Sofa In Sandy Brown Colour', 1639.98, 999.98, N'.PNG', 1, 1)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (5, N'Rovel Solid Wood Settee In Brown Colour', 699.98, 499.98, N'.PNG', 2, 2)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (6, N'Orpha Metal Settee In Grey Colour', 659.98, 469.98, N'.PNG', 2, 2)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (7, N'Maurya Solid Wood Settee In Honey Oak Finish', 879.98, 599.98, N'.PNG', 2, 2)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (8, N'Symes Settee In Honey Oak Finish', 639.98, 439.98, N'.PNG', 2, 2)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (9, N'Cubic Modular Wall Shelf (Set Of 6) In Black & Red Finish', 69.9, 55.92, N'.PNG', 3, 3)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (10, N'Florito Solid Wood Square Wall Shelf', 531, 211.98, N'.PNG', 3, 3)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (11, N'Brown Engineered Wood Round Set Of 4 Modular Wall Shelf', 83.5, 29.38, N'.PNG', 3, 3)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (12, N'Engineered Wood Floating Wall Shelves In Black Colour', 23.38, 19.78, N'.PNG', 3, 1)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (13, N'Alara Solid Wood Poster Bed In Honey Oak Finish', 2319.98, 1639.98, N'.PNG', 4, 4)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (14, N'Louisiana Solid Wood Poster Bed In Provincial Teak Finish', 2319.98, 1519.98, N'.PNG', 4, 3)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (15, N'Vayaka Solid Wood Poster Bed In Provincial Teak Finish', 2319.98, 1599.98, N'.PNG', 4, 1)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (16, N'Farmhouse Pine Wood Trundle Bunk Bed In White', 2579.98, 1639.98, N'.PNG', 5, 4)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (17, N'Farmhouse Pine Wood Bunk Bed With Trundle Storage In White', 2499.98, 1599.98, N'.PNG', 5, 3)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (18, N'Minerva Midsleeper Loft Bed In Angel White', 1919.18, 1239.98, N'.PNG', 5, 2)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (19, N'Roll-Away Folding Space Saving Bed With Free 6 Inch Foam Mattress', 359.98, 279.98, N'.PNG', 6, 1)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (20, N'Edison Folding Bed With Mattress In Black Finish', 529.78, 389.98, N'.PNG', 6, 2)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (21, N'Dreamer Metallic Folding Bed In Black Colour', 119.98, 90.52, N'.PNG', 6, 3)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (22, N'Joy Baby Crib In White', 259, 229.98, N'.PNG', 7, 4)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (23, N'McSilvie Convertible Baby Crib In Satin White Finish', 895.94, 431.98, N'.PNG', 7, 3)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (24, N'Georgia Crib Cum Toddler Bed (Without Mattress) In White', 659, 645.95, N'.PNG', 7, 2)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (25, N'Champion Study Table In Pink Colour', 419.98, 279.98, N'.PNG', 8, 1)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (26, N'Champion Study Table In Blue Colour', 419.98, 279.95, N'.PNG', 8, 2)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (27, N'Friends Study Unit In White & Lime Green Finish', 386.32, 239.98, N'.PNG', 8, 3)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (28, N'Three Layer Bookcase In Blue And White Colour', 419, 410.62, N'.PNG', 9, 4)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (29, N'Solo Bookcase In Majenta Colour', 359, 351.98, N'.PNG', 9, 2)
GO
INSERT [dbo].[FurnitureInfos] ([FurnitureInfoID], [FurnitureName], [OfferPrice], [Price], [Extension], [FurnitureSubCategoryID], [BrandID]) VALUES (30, N'Young America Bookcase In Blue', 430, 421.4, N'.PNG', 9, 3)
GO
SET IDENTITY_INSERT [dbo].[FurnitureInfos] OFF
GO
SET IDENTITY_INSERT [dbo].[Favourites] ON 
GO
INSERT [dbo].[Favourites] ([FavouriteID], [UserID], [FurnitureInfoID]) VALUES (1, N'jacob@gmail.com', 1)
GO
INSERT [dbo].[Favourites] ([FavouriteID], [UserID], [FurnitureInfoID]) VALUES (2, N'jacob@gmail.com', 25)
GO
INSERT [dbo].[Favourites] ([FavouriteID], [UserID], [FurnitureInfoID]) VALUES (3, N'jacob@gmail.com', 26)
GO
SET IDENTITY_INSERT [dbo].[Favourites] OFF
GO
