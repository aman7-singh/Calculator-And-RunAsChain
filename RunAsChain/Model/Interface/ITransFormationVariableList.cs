﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.Interface
{
    public interface ITransFormationVariableList
    {
        ObservableCollection<ITransformationVariable> TVariableList { get; }
    }
}
