using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model
{
    public enum XmlEnum
    {
        Transformation=1,
        createdon,
        createdby,
        ProcessingSteps,
        Map,
        Sequence,
        Name,
        MapFilePath,
        Location,
        SourceFilePath,
        TargetFilePath,
        CodeModules,
        CodeModulePath,
        TransformationVariables,
        Variable,
        Value,
        IsPublic,
        InitialValue
    }
    /*
     * <Transformation createdon="19-10-2018 12:25:50" createdby="Aman">
  <ProcessingSteps>
    <Map Sequence="1" Name="New1 Text Document">
      <MapFilePath Location="C:\Users\1994a\source\repos\Calculator\RunAsChain\DataForModel\New1 Text Document.txt"/>
      <SourceFilePath Location="C:\Users\1994a\source\repos\Calculator\RunAsChain\DataForModel\New1 Text Document1.txt"/>
      <TargetFilePath Location="C:\Users\1994a\source\repos\Calculator\RunAsChain\DataForModel\New1 Text Document2.txt"/>
      <CodeModules>
        <CodeModulePath Location="C:\Users\1994a\source\repos\Calculator\RunAsChain\DataForModel\New1 Text Document3.txt"/>
        <CodeModulePath Location="C:\Users\1994a\source\repos\Calculator\RunAsChain\DataForModel\New1 Text Document4.txt"/>
      </CodeModules>
      <TransformationVariables>
        <Variable Value="A" IsPublic="No" InitialValue="1"/>
        <Variable Value="B" IsPublic="No" InitialValue="1"/>
        <Variable Value="C" IsPublic="No" InitialValue="1"/>
      </TransformationVariables>
    </Map>
    */
}
