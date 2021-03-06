Imports System
Imports EnvDTE
Imports EnvDTE80
Imports System.Diagnostics

Public Module TestMacros
    ' Transforms all templates to generate latest output with them, then runs all tests with TestDriven.NET
    Sub RunTestsWithTestDrivenNet()
        DTE.ExecuteCommand("TextTransformation.TransformAllTemplates")
        DTE.ExecuteCommand("TestDriven.NET.Client")
    End Sub
End Module
