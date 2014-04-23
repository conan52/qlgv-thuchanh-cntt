USE [ThucHanhCNTT]
GO
/****** Object:  Table [dbo].[webpages_Roles]    Script Date: 04/23/2014 10:14:26 ******/
SET IDENTITY_INSERT [dbo].[webpages_Roles] ON
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (3, N'Admin')
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (4, N'AdminTeacher')
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (1, N'Blocked')
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (2, N'Teacher')
SET IDENTITY_INSERT [dbo].[webpages_Roles] OFF
/****** Object:  Table [dbo].[webpages_OAuthMembership]    Script Date: 04/23/2014 10:14:26 ******/
/****** Object:  Table [dbo].[webpages_Membership]    Script Date: 04/23/2014 10:14:26 ******/
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (1, CAST(0x0000A3160033BCB6 AS DateTime), NULL, 1, NULL, 0, N'ALxz6wJ2Rq/Yfk1EBrrq7yFTmxrXF+6kpIGEsll9WaB/2lCLd+GAWyRYANxGgBQH8w==', CAST(0x0000A3160033BCB6 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (3, CAST(0x0000A3160034BAC6 AS DateTime), NULL, 1, NULL, 0, N'APj/AdSHHwx7bnMPAM3uhWMJCjwsYjcMF5Ui5kwubIc9mu9A3C6g7SzIfGgltP40Ag==', CAST(0x0000A3160034BAC6 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (4, CAST(0x0000A3160034BAEC AS DateTime), NULL, 1, NULL, 0, N'AE+YpfYhzZ0a7zQLRDPHLTgwCIpM24sYkwLtapF5Pkr/0MDe0wdcsKEXXesd3uZOwg==', CAST(0x0000A3160034BAEC AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (5, CAST(0x0000A3160034BAF8 AS DateTime), NULL, 1, NULL, 0, N'ALlWY+6j6kwJqc971Q9ktqAhBI5OjPtOV1CpBmZ7JNcr/QSjUyQHqm0d0zNY2Nx5WA==', CAST(0x0000A3160034BAF8 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (6, CAST(0x0000A3160034BB01 AS DateTime), NULL, 1, NULL, 0, N'AGriUykdJoWiCnWV17q6/512yJj6PpNwgi/Ic2t9E01L4C1ff29TjAcHGrX5Qi3lRw==', CAST(0x0000A3160034BB01 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (7, CAST(0x0000A3160034BB0A AS DateTime), NULL, 1, NULL, 0, N'AC5BocIbPOdJhA7W5sDnL2Zj3eCuTg5z+CUcJC8wS/0bWYhYYueBUUu8GYGQk+6cJA==', CAST(0x0000A3160034BB0A AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (8, CAST(0x0000A3160034BB1E AS DateTime), NULL, 1, NULL, 0, N'ABNGd/WS0NliYGgAl17FOQzEgMMb9xV+ShnyR4CWH7pe9wUEcrlxTmAfahutbUwlFw==', CAST(0x0000A3160034BB1E AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (9, CAST(0x0000A3160034BB28 AS DateTime), NULL, 1, NULL, 0, N'ALS2zz6Sx+Q2NOc5kJ5eJuO1QHJWRtFnjpJclvNb0/rTY1yrT084TQdHCvplTZzWmw==', CAST(0x0000A3160034BB28 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (10, CAST(0x0000A3160034BB32 AS DateTime), NULL, 1, NULL, 0, N'AJkOUkpJqOyTxyhDrKk/5oijfUSbgjxN3/q3nIvffLC2hdtrGbE4jrB3IlkQp7PQzg==', CAST(0x0000A3160034BB32 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (11, CAST(0x0000A3160034BB3A AS DateTime), NULL, 1, NULL, 0, N'AAOBApu37x3I6HMJZ9W4DxPrkLHzJQXBtEHA1zbSr6G3Y1OI8JSEghixFwzfiTbd5g==', CAST(0x0000A3160034BB3A AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (12, CAST(0x0000A3160034BB46 AS DateTime), NULL, 1, NULL, 0, N'AMfPwAiPmZqBszUyrwQeHHNFt51praNUUoUBnP6oZN/89eYBC+whqNHeDvjsIJU77A==', CAST(0x0000A3160034BB46 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (13, CAST(0x0000A3160034BB4E AS DateTime), NULL, 1, NULL, 0, N'ACdz12k7MvfGBBfXXL4soSpE+pGL+G42JXSEb2OQmjw/hkugbU245NywvtK7dNcnuA==', CAST(0x0000A3160034BB4E AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (14, CAST(0x0000A3160034BB55 AS DateTime), NULL, 1, NULL, 0, N'APVef7oWem6GiYUtyzpcfb1Nnr3tNyzhz89oOckrNg6eQYCMwPDFBh165VhrJ+gMzQ==', CAST(0x0000A3160034BB55 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (15, CAST(0x0000A3160034BB5E AS DateTime), NULL, 1, NULL, 0, N'AIzvIAHnCjoEk7FrV1sV4jvW7v9VAVOxoIBJLnsnZVgXu3Lxzc79TvXVcODFZPlylA==', CAST(0x0000A3160034BB5E AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (16, CAST(0x0000A3160034BB65 AS DateTime), NULL, 1, NULL, 0, N'AIN4YPyw4Dw2c9LxC6mxS+miR01b5eohchiQNm934IvYA105HlpQX6yqohfBl3x24w==', CAST(0x0000A3160034BB65 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (17, CAST(0x0000A3160034BB6D AS DateTime), NULL, 1, NULL, 0, N'AMBwD6ZYCmcGz/uuZMHbdW6fUveQdM3yUM+FwUBweS4CYN+vBnDx9/TXhZj5xLAUgg==', CAST(0x0000A3160034BB6D AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (18, CAST(0x0000A3160034BB75 AS DateTime), NULL, 1, NULL, 0, N'APF50R4PGjX8aN99kAeKu73zpNSOyu5Coyqg4Ar1PgG9V0ltA6vAGRvb9mk0Hx4yaA==', CAST(0x0000A3160034BB75 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (19, CAST(0x0000A3160034BB7D AS DateTime), NULL, 1, NULL, 0, N'AOBpnoStzE/LLpH9AoT6Z+d6OUiay1AnHoa0fKSbjeuSy+tiZmZ2jS1hpnJufAbbLQ==', CAST(0x0000A3160034BB7D AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (20, CAST(0x0000A3160034BB84 AS DateTime), NULL, 1, NULL, 0, N'AJKX5emRbFk7OD3sqWTHE4sUwPSIZ7b/jRfPvWAkNm7S7VQ7RB4oga05WPR35+trEw==', CAST(0x0000A3160034BB84 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (21, CAST(0x0000A3160034BB8D AS DateTime), NULL, 1, NULL, 0, N'ALFPpNE5PgqdZ9dCBmLGS/tIRLhtrCFT6bPEY70E8K1T19uS3lYdocyNPytZmwQjpQ==', CAST(0x0000A3160034BB8D AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (22, CAST(0x0000A3160034BB94 AS DateTime), NULL, 1, NULL, 0, N'AHhlUNMlBiYKLO69Lr/AQA/5SVe0GCwlm0qm7sk56HYLWKOuWEvNvq0k/j8VbBTUvg==', CAST(0x0000A3160034BB94 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (23, CAST(0x0000A3160034BB9C AS DateTime), NULL, 1, NULL, 0, N'AB7gNSMhrVg/uQh6GsFvSO80y/suy/u3kkibHE8Hvmyutjw4V6bUdnhldHxpRR6QCg==', CAST(0x0000A3160034BB9C AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (24, CAST(0x0000A3160034BBA8 AS DateTime), NULL, 1, NULL, 0, N'AFDcyWdUuM1YHXAactL5HyPqvRN/+KI5scBxjLbCoZ0SKgKTLTe75SzQ3Ld8z2087A==', CAST(0x0000A3160034BBA8 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (25, CAST(0x0000A3160034BBAF AS DateTime), NULL, 1, NULL, 0, N'AGIft56yIa5bg1a6/BXLThNIAo67cY8UPFtYONMJjoJ2HPXpqn+VIyk2WrW4tE/aZQ==', CAST(0x0000A3160034BBAF AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (26, CAST(0x0000A3160034BBB8 AS DateTime), NULL, 1, NULL, 0, N'AOcwfsa0MPfdChwRmJozlPz0hPucwCX1TrF473LN+zU9N5E95yCE9yPnWZ7AOlHszw==', CAST(0x0000A3160034BBB8 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (27, CAST(0x0000A3160034BBBF AS DateTime), NULL, 1, NULL, 0, N'AF2dmnOJLZqOS34W8vrxopypg8DLQQCN/2BM36Hf07eXqY0/3zINZFSu+OsovluiNA==', CAST(0x0000A3160034BBBF AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (28, CAST(0x0000A3160034BBC7 AS DateTime), NULL, 1, NULL, 0, N'AKxFtL/eMovF1tqhIW0ly7iFmGSjAbwBmSuSX9BBc3IL1WvBvmMTvBPaEXOrRfbjAg==', CAST(0x0000A3160034BBC7 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (29, CAST(0x0000A3160034BBE1 AS DateTime), NULL, 1, NULL, 0, N'AOJAvBKFq2mAFPJZmexcurNSW6PATTA2FWJURL2suZ86ugJKRtlKgRkrf9WF86mSWg==', CAST(0x0000A3160034BBE1 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (30, CAST(0x0000A3160034BBE9 AS DateTime), NULL, 1, NULL, 0, N'ACUQBSvO5dJ5C7gkCyb2WfIJBrp6TXJg+48AZmj72JolFlMC5e1mlpzVbg/ogbKUdg==', CAST(0x0000A3160034BBE9 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (31, CAST(0x0000A3160034BBF0 AS DateTime), NULL, 1, NULL, 0, N'ALgzv+MQTKYnxGba6m0hFO3MXNZxMwexXh1ryewqEBL7+mvNgYlqsxez36RBHAFZNQ==', CAST(0x0000A3160034BBF0 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (32, CAST(0x0000A3160034BBF8 AS DateTime), NULL, 1, NULL, 0, N'AKc2tmAFFDMLw/4FyvPUUspg/lCM7RwES9JNC6wNMaKJfZQaDKhoFVNCTyybHgy1NA==', CAST(0x0000A3160034BBF8 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (33, CAST(0x0000A3160034BC00 AS DateTime), NULL, 1, NULL, 0, N'ACbPw/K/xvtq6JZWMPYrmqwiE4Aan/I/DHSUA3N9YbbPZvsU/gwdyGU41F9krWIZzQ==', CAST(0x0000A3160034BC00 AS DateTime), N'', NULL, NULL)
/****** Object:  Table [dbo].[UserProfile]    Script Date: 04/23/2014 10:14:26 ******/
SET IDENTITY_INSERT [dbo].[UserProfile] ON
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (1, N' ', N'Admin', N'Admin')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (3, N'CT02', N'conglg', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (4, N'CT03', N'binhntt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (5, N'CT07', N'ngaptt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (6, N'CT08', N'thangth', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (7, N'CT09', N'locpd', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (8, N'CT13', N'phucnv', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (9, N'CT15', N'hunghm', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (10, N'CT19', N'anhpt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (11, N'CT20', N'khanhtnn', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (12, N'CT24', N'trangnth', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (13, N'CT25', N'cuongdn', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (14, N'CT28', N'luongnt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (15, N'CT29', N'binhvp', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (16, N'CT31', N'thylu', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (17, N'CT33', N'binhnt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (18, N'CT36', N'baclh', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (19, N'CT45', N'toandn', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (20, N'CT46', N'quytd', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (21, N'CT48', N'linhlv', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (22, N'CT49', N'luyenln', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (23, N'CT51', N'linhttp', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (24, N'CT59', N'choihk', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (25, N'CT60', N'duongnh', N'AdminTeacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (26, N'CT65', N'quanvm', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (27, N'CT68', N'khuedm', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (28, N'TH01', N'hiepnm', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (29, N'TN12', N'haidt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (30, N'TN15', N'minhtt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (31, N'TN16', N'nghiapv', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (32, N'TN20', N'thongt', N'Teacher')
INSERT [dbo].[UserProfile] ([UserId], [MaGv], [UserName], [Role]) VALUES (33, N'TN22', N'tintc', N'Teacher')
SET IDENTITY_INSERT [dbo].[UserProfile] OFF
/****** Object:  Table [dbo].[webpages_UsersInRoles]    Script Date: 04/23/2014 10:14:26 ******/
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (1, 3)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (3, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (4, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (5, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (6, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (7, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (8, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (9, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (10, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (11, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (12, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (13, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (14, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (15, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (16, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (17, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (18, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (19, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (20, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (21, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (22, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (23, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (24, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (25, 4)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (26, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (27, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (28, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (29, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (30, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (31, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (32, 2)
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (33, 2)
