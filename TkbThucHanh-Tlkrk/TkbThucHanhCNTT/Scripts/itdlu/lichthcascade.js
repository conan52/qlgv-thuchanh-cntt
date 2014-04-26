

function getCurrentEditedModel() {
    var grid = $("#GridView").data("kendoGrid");
    var editRow = grid.tbody.find("tr:has(.k-edit-cell)");
    return grid.dataItem(editRow);
};

function onChange(e) {
    if (e.action == "itemchange") {
        var model = e.items[0];
        // alert(e.field);
        if (e.field == "TenLop") {
            model.set("MonHocId", 0);
        }

        if (e.field == "MonHocId") {
            //alert(model.MonHocId);
            model.set("Gvhd1", 0);
            model.set("Gvhd2", 0);
            model.set("Gvhd3", 0);
        }

        if (e.field == "Gvhd1") {
            // model.set("Gvhd1", 0);
            // model.set("Gvhd2", 0);
            // model.set("Gvhd3", 0);
        }
        if (e.field == "Gvhd2") {
            //  model.set("Gvhd1", 0);
            //   model.set("Gvhd2", 0);
            //  model.set("Gvhd3", 0);
        }
        if (e.field == "Gvhd3") {
            //  model.set("Gvhd1", 0);
            //  model.set("Gvhd2", 0);
            //   model.set("Gvhd3", 0);
        }
    }
};

function locTheoLop() {
    var model = getCurrentEditedModel();
    return {
        TenLop: model.TenLop
    };
};

function locMaGv2() {
    var model = getCurrentEditedModel();
    return {
        SttTuan: model.SttTuan,
        NgayTrongTuan: model.NgayTrongTuan,
        TietBatDau: model.TietBatDau,
        TietKetThuc: model.TietKetThuc,
        GvA: model.Gvhd1,
        GvB: model.Gvhd3,
        ChuyenNganh: model.ChuyenNganh
    };
};

function locMaGv3() {
    var model = getCurrentEditedModel();
    return {
        SttTuan: model.SttTuan,
        NgayTrongTuan: model.NgayTrongTuan,
        TietBatDau: model.TietBatDau,
        TietKetThuc: model.TietKetThuc,
        GvA: model.Gvhd1,
        GvB: model.Gvhd2,
        ChuyenNganh: model.ChuyenNganh
    };
};

function layGvPhanCong() {
    var model = getCurrentEditedModel();
    return {
        TenLop: model.TenLop,
        MonHocId: model.MonHocId
    };
};