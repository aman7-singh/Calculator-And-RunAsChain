using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    public class TransformationModel: ITransformationModel
    {
        private XmlEnum _elementName;
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

        private ProcessingStepsModel _processingStepsModel;

        public ProcessingStepsModel ProcessingStepsModel
        {
            get { return _processingStepsModel; }
            set { _processingStepsModel = value; }
        }

        public TransformationModel(XmlEnum elementName)
        {
            _elementName = elementName;
        }

        public void AddTransformationModel(XmlEnum elementName, string createdon, string createdby, ProcessingStepsModel processingSteps)
        {
            _elementName = elementName;
            _createdOn = createdon;
            _createdBy = createdby;
            _processingStepsModel = processingSteps;
        }
    }
}
