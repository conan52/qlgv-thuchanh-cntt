

    function getCurrentEditedModel() {
        var grid = $("#GridView").data("kendoGrid");
        var editRow = grid.tbody.find("tr:has(.k-edit-cell)");
        return grid.dataItem(editRow);
    }


 function onChange(e) {
        if (e.action == "itemchange") {
            // alert(e.field);
            if (e.field == "TenLop") {
                var model = e.items[0];
                model.set("MonHocId", 0);
            }

            if (e.field == "MonHocId") {
                var model = e.items[0];
                model.set("GvHd1", 0);
                model.set("GvHd2", 0);
                model.set("GvHd3", 0);
            }

            if (e.field == "GvHd1") {
                var model = e.items[0];
              // model.set("GvHd1", 0);
               model.set("GvHd2", 0);
               model.set("GvHd3", 0);
            } 
            if (e.field == "GvHd2") {
                var model = e.items[0];
                model.set("GvHd1", 0);
             //   model.set("GvHd2", 0);
                model.set("GvHd3", 0);
            } 
            if (e.field == "GvHd3") {
                var model = e.items[0];
                model.set("GvHd1", 0);
                model.set("GvHd2", 0);
            //    model.set("GvHd3", 0);
            }
        }
    }

    function locTheoLop() {
        var model = getCurrentEditedModel();
        return {
            TenLop: model.TenLop
        };

    }

    function locMaGv2() {
        var model = getCurrentEditedModel();
        return {
            SttTuan: model.SttTuan,
            NgayTrongTuan: model.NgayTrongTuan,
            TietBatDau: model.TietBatDau,
            TietKetThuc: model.TietKetThuc,
            GvA : model.Gvhd1,
            GvB : model.Gvhd3,
        };

    }

    
    function locMaGv3() {
        var model = getCurrentEditedModel();
        return {
            SttTuan: model.SttTuan,
            NgayTrongTuan: model.NgayTrongTuan,
            TietBatDau: model.TietBatDau,
            TietKetThuc: model.TietKetThuc,
            GvA : model.GvHd1,
            GvB : model.GvHd2,
        };

    }


    function layGvPhanCong() {
        var model = getCurrentEditedModel();
        return {
            TenLop: model.TenLop,
            MonHocId: model.MonHocId,
        };

    }
