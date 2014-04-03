using System.Web.UI.WebControls;
using DevExpress.Web.ASPxClasses;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.Mvc;

namespace TkbThucHanh.ViewSettings
{
    public static class GridViewUltils
    {
        public static void SettingDefaultColumn(this GridViewSettings settings)
        {
            settings.SettingsPager.PageSize = 50;
            settings.SettingsBehavior.ConfirmDelete = true;
            settings.SettingsEditing.Mode = GridViewEditingMode.PopupEditForm;
            settings.Width = Unit.Percentage(90);
            settings.SettingsBehavior.ColumnResizeMode = ColumnResizeMode.NextColumn;
            settings.SettingsPopup.EditForm.Width = 600;
            settings.SettingsPopup.EditForm.HorizontalAlign = PopupHorizontalAlign.Center;
            settings.SettingsPopup.EditForm.VerticalAlign = PopupVerticalAlign.Middle;

            settings.SettingsText.GroupPanel = " ";


            settings.CommandColumn.Visible = true;
            //  settings.CommandColumn.NewButton.Visible = true;
            settings.CommandColumn.DeleteButton.Visible = true;
            settings.CommandColumn.EditButton.Visible = true;


            settings.SettingsPager.Visible = true;
            settings.Settings.ShowGroupPanel = true;
            settings.Settings.ShowFilterRow = true;
            settings.SettingsBehavior.AllowSelectByRowClick = true;
            

            settings.CommandColumn.DeleteButton.Text = "Xóa";
            //      settings.CommandColumn.NewButton.Text = "Thêm";
            settings.CommandColumn.EditButton.Text = "Sửa";
            settings.CommandColumn.CancelButton.Text = "Hủy bỏ";
            settings.CommandColumn.UpdateButton.Text = "Áp dụng";
            settings.CommandColumn.ClearFilterButton.Visible = true;
            settings.CommandColumn.Width = 150;
//            settings.CommandColumn.VisibleIndex = settings.Columns.Count;//////////////
            settings.CommandColumn.VisibleIndex = settings.Columns.Count;
            settings.CommandColumn.ButtonType = ButtonType.Link;
            settings.CommandColumn.DeleteButton.Image.Url = "~/Content/Images/delete.png";
            //              settings.CommandColumn.DeleteButton.Image.SpriteProperties. = "~/Content/Images/delete.png";
        }

        public static void SetCommandColumn(this GridViewSettings settings)
        {
            settings.CommandColumn.VisibleIndex = settings.Columns.Count;
            settings.CommandColumn.Width = 100;
        }
    }
}