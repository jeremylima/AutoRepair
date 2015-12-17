using System.Collections.Generic;
using AutoRepair.Business.Models;
using DevExpress.XtraEditors;

namespace AutoRepair.UI.WinForms.Commons
{
    public class ComponentFiller
    {
        public static FillLookUpEditCommand FillLookUpEdit(LookUpEdit lookUpEdit)
        {
            return new FillLookUpEditCommand(lookUpEdit);
        }
    }

    public class FillLookUpEditCommand
    {
        private readonly LookUpEdit _lookUpEdit;

        public FillLookUpEditCommand(LookUpEdit lookUpEdit)
        {
            _lookUpEdit = lookUpEdit;
        }

        public void Data<T>(IEnumerable<T> dataSource, string displayMember, string valueMember, int indexItemSelected)
        {
            _lookUpEdit.Properties.DataSource = dataSource;
            _lookUpEdit.Properties.DisplayMember = displayMember;
            _lookUpEdit.Properties.ValueMember = valueMember;

            if (indexItemSelected == 0)
                _lookUpEdit.ItemIndex = indexItemSelected;
            else
                _lookUpEdit.EditValue = indexItemSelected;
        }
    }
   
}