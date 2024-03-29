
        DELETE  FROM [LichThucHanh]
        WHERE   MaLichTh NOT IN ( SELECT    MIN(MaLichTh)
                                  FROM      [LichThucHanh]
                                  GROUP BY  TietBatDau ,
                                            NgayTrongTuan ,
                                            SttTuan ,
                                            MonHocId )
                            
        
        DELETE  FROM dbo.TkbGiangVien
        WHERE   MaTkb NOT IN ( SELECT   MIN(MaTkb)
                               FROM     TkbGiangVien
                               GROUP BY TietBatDau ,
                                        NgayTrongTuan ,
                                        SttTuan ,
                                        MaGv )