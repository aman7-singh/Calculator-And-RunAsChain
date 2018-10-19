using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    class TransformationModel: ITransformationModel
    {
        private string _createdOn;

        public string CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }

        private string _createdBy;

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        TransformationModel(string createdon, string createdby)
        {
            _createdOn = createdon;
            _createdBy = createdby;
        }
    }
}
