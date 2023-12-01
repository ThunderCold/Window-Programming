IF NOT EXISTS (SELECT 1 FROM [dbo].[寶可夢_招式] WHERE 寶可夢 = N'呆火鱷')
BEGIN
INSERT INTO [dbo].[寶可夢_招式] ([寶可夢], [招式]) VALUES (N'呆火鱷', N'火花')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[寶可夢_招式] WHERE 寶可夢 = N'新葉喵')
BEGIN
INSERT INTO [dbo].[寶可夢_招式] ([寶可夢], [招式]) VALUES (N'新葉喵', N'樹葉')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[寶可夢_招式] WHERE 寶可夢 = N'潤水鴨')
BEGIN
INSERT INTO [dbo].[寶可夢_招式] ([寶可夢], [招式]) VALUES (N'潤水鴨', N'水槍')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[屬性_克制屬性_被克制屬性] WHERE 屬性 = N'水')
BEGIN
INSERT INTO [dbo].[屬性_克制屬性_被克制屬性] ([屬性], [克制屬性], [被克制屬性]) VALUES (N'水', N'火', N'草')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[屬性_克制屬性_被克制屬性] WHERE 屬性 = N'火')
BEGIN
INSERT INTO [dbo].[屬性_克制屬性_被克制屬性] ([屬性], [克制屬性], [被克制屬性]) VALUES (N'火', N'草', N'水')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[屬性_克制屬性_被克制屬性] WHERE 屬性 = N'草')
BEGIN
INSERT INTO [dbo].[屬性_克制屬性_被克制屬性] ([屬性], [克制屬性], [被克制屬性]) VALUES (N'草', N'水', N'火')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[招式_屬性_威力] WHERE 招式 = N'樹葉')
BEGIN
    INSERT INTO [dbo].[招式_屬性_威力] ([招式], [屬性], [威力]) VALUES (N'樹葉', N'草', 40)
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[招式_屬性_威力] WHERE 招式 = N'水槍')
BEGIN
    INSERT INTO [dbo].[招式_屬性_威力] ([招式], [屬性], [威力]) VALUES (N'水槍', N'水', 40)
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[招式_屬性_威力] WHERE 招式 = N'火花')
BEGIN
    INSERT INTO [dbo].[招式_屬性_威力] ([招式], [屬性], [威力]) VALUES (N'火花', N'火', 40)
END

UPDATE 寶可夢_招式 SET 招式=N'水流噴射' WHERE 寶可夢=N'潤水鴨'
UPDATE 招式_屬性_威力 SET 威力=60 WHERE 招式=N'火花'

SELECT * FROM 寶可夢_招式
SELECT * FROM 招式_屬性_威力
SELECT * FROM 屬性_克制屬性_被克制屬性