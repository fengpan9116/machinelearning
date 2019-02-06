﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace mlnet.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ConsoleHelper : ConsoleHelperBase
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using System;\r\nusing System.IO;\r\nusing System.IO.Compression;\r\nusing System.Linq;" +
                    "\r\nusing Microsoft.ML.Core.Data;\r\nusing System.Collections.Generic;\r\nusing Micros" +
                    "oft.ML.Data;\r\nusing Microsoft.ML;\r\n\r\nusing System.Reflection;\r\n\r\nnamespace Mlnet" +
                    "Sample\r\n{\r\n    public static class ConsoleHelper\r\n    {\r\n        public static v" +
                    "oid PrintPrediction(string prediction)\r\n        {\r\n            Console.WriteLine" +
                    "($\"*************************************************\");\r\n            Console.Wri" +
                    "teLine($\"Predicted : {prediction}\");\r\n            Console.WriteLine($\"**********" +
                    "***************************************\");\r\n        }\r\n\r\n        public static v" +
                    "oid PrintRegressionPredictionVersusObserved(string predictionCount, string obser" +
                    "vedCount)\r\n        {\r\n            Console.WriteLine($\"--------------------------" +
                    "-----------------------\");\r\n            Console.WriteLine($\"Predicted : {predict" +
                    "ionCount}\");\r\n            Console.WriteLine($\"Actual:     {observedCount}\");\r\n  " +
                    "          Console.WriteLine($\"-------------------------------------------------\"" +
                    ");\r\n        }\r\n\r\n        //(CDLTLL-Pending to Fix - Results --> ?)\r\n        //\r\n" +
                    "        public static void PrintRegressionMetrics(string name, RegressionMetrics" +
                    " metrics)\r\n        {\r\n            Console.WriteLine($\"**************************" +
                    "***********************\");\r\n            Console.WriteLine($\"*       Metrics for " +
                    "{name} regression model      \");\r\n            Console.WriteLine($\"*-------------" +
                    "-----------------------------------\");\r\n            Console.WriteLine($\"*       " +
                    "LossFn:        {metrics.LossFn:0.##}\");\r\n            Console.WriteLine($\"*      " +
                    " R2 Score:      {metrics.RSquared:0.##}\");\r\n            Console.WriteLine($\"*   " +
                    "    Absolute loss: {metrics.L1:#.##}\");\r\n            Console.WriteLine($\"*      " +
                    " Squared loss:  {metrics.L2:#.##}\");\r\n            Console.WriteLine($\"*       RM" +
                    "S loss:      {metrics.Rms:#.##}\");\r\n            Console.WriteLine($\"************" +
                    "*************************************\");\r\n        }\r\n\r\n        public static voi" +
                    "d PrintBinaryClassificationMetrics(string name, CalibratedBinaryClassificationMe" +
                    "trics metrics)\r\n        {\r\n            Console.WriteLine($\"*********************" +
                    "***************************************\");\r\n            Console.WriteLine($\"*   " +
                    "    Metrics for {name} binary classification model      \");\r\n            Console" +
                    ".WriteLine($\"*-----------------------------------------------------------\");\r\n  " +
                    "          Console.WriteLine($\"*       Accuracy: {metrics.Accuracy:P2}\");\r\n      " +
                    "      Console.WriteLine($\"*       Auc:      {metrics.Auc:P2}\");\r\n            Con" +
                    "sole.WriteLine($\"*       Auprc:  {metrics.Auprc:P2}\");\r\n            Console.Writ" +
                    "eLine($\"*       F1Score:  {metrics.F1Score:P2}\");\r\n            Console.WriteLine" +
                    "($\"*       LogLoss:  {metrics.LogLoss:#.##}\");\r\n            Console.WriteLine($\"" +
                    "*       LogLossReduction:  {metrics.LogLossReduction:#.##}\");\r\n            Conso" +
                    "le.WriteLine($\"*       PositivePrecision:  {metrics.PositivePrecision:#.##}\");\r\n" +
                    "            Console.WriteLine($\"*       PositiveRecall:  {metrics.PositiveRecall" +
                    ":#.##}\");\r\n            Console.WriteLine($\"*       NegativePrecision:  {metrics." +
                    "NegativePrecision:#.##}\");\r\n            Console.WriteLine($\"*       NegativeReca" +
                    "ll:  {metrics.NegativeRecall:P2}\");\r\n            Console.WriteLine($\"***********" +
                    "*************************************************\");\r\n        }\r\n\r\n        publi" +
                    "c static void PrintMultiClassClassificationMetrics(string name, MultiClassClassi" +
                    "fierMetrics metrics)\r\n        {\r\n            Console.WriteLine($\"***************" +
                    "*********************************************\");\r\n            Console.WriteLine(" +
                    "$\"*    Metrics for {name} multi-class classification model   \");\r\n            Co" +
                    "nsole.WriteLine($\"*-----------------------------------------------------------\")" +
                    ";\r\n            Console.WriteLine($\"    AccuracyMacro = {metrics.AccuracyMacro:0." +
                    "####}, a value between 0 and 1, the closer to 1, the better\");\r\n            Cons" +
                    "ole.WriteLine($\"    AccuracyMicro = {metrics.AccuracyMicro:0.####}, a value betw" +
                    "een 0 and 1, the closer to 1, the better\");\r\n            Console.WriteLine($\"   " +
                    " LogLoss = {metrics.LogLoss:0.####}, the closer to 0, the better\");\r\n           " +
                    " Console.WriteLine($\"    LogLoss for class 1 = {metrics.PerClassLogLoss[0]:0.###" +
                    "#}, the closer to 0, the better\");\r\n            Console.WriteLine($\"    LogLoss " +
                    "for class 2 = {metrics.PerClassLogLoss[1]:0.####}, the closer to 0, the better\")" +
                    ";\r\n            Console.WriteLine($\"    LogLoss for class 3 = {metrics.PerClassLo" +
                    "gLoss[2]:0.####}, the closer to 0, the better\");\r\n            Console.WriteLine(" +
                    "$\"************************************************************\");\r\n        }\r\n\r\n" +
                    "        //(CDLTLL-Pending to Fix - Results --> ?)\r\n\r\n        public static void " +
                    "PrintRegressionFoldsAverageMetrics(string algorithmName,\r\n                      " +
                    "                                        (RegressionMetrics metrics,\r\n           " +
                    "                                                    ITransformer model,\r\n       " +
                    "                                                        IDataView scoredTestData" +
                    ")[] crossValidationResults\r\n                                                    " +
                    "         )\r\n        {\r\n            var L1 = crossValidationResults.Select(r => r" +
                    ".metrics.L1);\r\n            var L2 = crossValidationResults.Select(r => r.metrics" +
                    ".L2);\r\n            var RMS = crossValidationResults.Select(r => r.metrics.L1);\r\n" +
                    "            var lossFunction = crossValidationResults.Select(r => r.metrics.Loss" +
                    "Fn);\r\n            var R2 = crossValidationResults.Select(r => r.metrics.RSquared" +
                    ");\r\n\r\n            Console.WriteLine($\"******************************************" +
                    "*******************************************************************\");\r\n        " +
                    "    Console.WriteLine($\"*       Metrics for {algorithmName} Regression model    " +
                    "  \");\r\n            Console.WriteLine($\"*----------------------------------------" +
                    "--------------------------------------------------------------------\");\r\n       " +
                    "     Console.WriteLine($\"*       Average L1 Loss:    {L1.Average():0.###} \");\r\n " +
                    "           Console.WriteLine($\"*       Average L2 Loss:    {L2.Average():0.###} " +
                    " \");\r\n            Console.WriteLine($\"*       Average RMS:          {RMS.Average" +
                    "():0.###}  \");\r\n            Console.WriteLine($\"*       Average Loss Function: {" +
                    "lossFunction.Average():0.###}  \");\r\n            Console.WriteLine($\"*       Aver" +
                    "age R-squared: {R2.Average():0.###}  \");\r\n            Console.WriteLine($\"******" +
                    "********************************************************************************" +
                    "***********************\");\r\n        }\r\n\r\n        public static void PrintMulticl" +
                    "assClassificationFoldsAverageMetrics(\r\n                                         " +
                    "string algorithmName,\r\n                                         (MultiClassClass" +
                    "ifierMetrics metrics,\r\n                                          ITransformer mo" +
                    "del,\r\n                                          IDataView scoredTestData)[] cros" +
                    "sValResults\r\n                                                                   " +
                    "        )\r\n        {\r\n            var metricsInMultipleFolds = crossValResults.S" +
                    "elect(r => r.metrics);\r\n\r\n            var microAccuracyValues = metricsInMultipl" +
                    "eFolds.Select(m => m.AccuracyMicro);\r\n            var microAccuracyAverage = mic" +
                    "roAccuracyValues.Average();\r\n            var microAccuraciesStdDeviation = Calcu" +
                    "lateStandardDeviation(microAccuracyValues);\r\n            var microAccuraciesConf" +
                    "idenceInterval95 = CalculateConfidenceInterval95(microAccuracyValues);\r\n\r\n      " +
                    "      var macroAccuracyValues = metricsInMultipleFolds.Select(m => m.AccuracyMac" +
                    "ro);\r\n            var macroAccuracyAverage = macroAccuracyValues.Average();\r\n   " +
                    "         var macroAccuraciesStdDeviation = CalculateStandardDeviation(macroAccur" +
                    "acyValues);\r\n            var macroAccuraciesConfidenceInterval95 = CalculateConf" +
                    "idenceInterval95(macroAccuracyValues);\r\n\r\n            var logLossValues = metric" +
                    "sInMultipleFolds.Select(m => m.LogLoss);\r\n            var logLossAverage = logLo" +
                    "ssValues.Average();\r\n            var logLossStdDeviation = CalculateStandardDevi" +
                    "ation(logLossValues);\r\n            var logLossConfidenceInterval95 = CalculateCo" +
                    "nfidenceInterval95(logLossValues);\r\n\r\n            var logLossReductionValues = m" +
                    "etricsInMultipleFolds.Select(m => m.LogLossReduction);\r\n            var logLossR" +
                    "eductionAverage = logLossReductionValues.Average();\r\n            var logLossRedu" +
                    "ctionStdDeviation = CalculateStandardDeviation(logLossReductionValues);\r\n       " +
                    "     var logLossReductionConfidenceInterval95 = CalculateConfidenceInterval95(lo" +
                    "gLossReductionValues);\r\n\r\n            Console.WriteLine($\"**********************" +
                    "********************************************************************************" +
                    "*******\");\r\n            Console.WriteLine($\"*       Metrics for {algorithmName} " +
                    "Multi-class Classification model      \");\r\n            Console.WriteLine($\"*----" +
                    "--------------------------------------------------------------------------------" +
                    "------------------------\");\r\n            Console.WriteLine($\"*       Average Mic" +
                    "roAccuracy:    {microAccuracyAverage:0.###}  - Standard deviation: ({microAccura" +
                    "ciesStdDeviation:#.###})  - Confidence Interval 95%: ({microAccuraciesConfidence" +
                    "Interval95:#.###})\");\r\n            Console.WriteLine($\"*       Average MacroAccu" +
                    "racy:    {macroAccuracyAverage:0.###}  - Standard deviation: ({macroAccuraciesSt" +
                    "dDeviation:#.###})  - Confidence Interval 95%: ({macroAccuraciesConfidenceInterv" +
                    "al95:#.###})\");\r\n            Console.WriteLine($\"*       Average LogLoss:       " +
                    "   {logLossAverage:#.###}  - Standard deviation: ({logLossStdDeviation:#.###})  " +
                    "- Confidence Interval 95%: ({logLossConfidenceInterval95:#.###})\");\r\n           " +
                    " Console.WriteLine($\"*       Average LogLossReduction: {logLossReductionAverage:" +
                    "#.###}  - Standard deviation: ({logLossReductionStdDeviation:#.###})  - Confiden" +
                    "ce Interval 95%: ({logLossReductionConfidenceInterval95:#.###})\");\r\n            " +
                    "Console.WriteLine($\"************************************************************" +
                    "*************************************************\");\r\n\r\n        }\r\n\r\n        pub" +
                    "lic static double CalculateStandardDeviation(IEnumerable<double> values)\r\n      " +
                    "  {\r\n            double average = values.Average();\r\n            double sumOfSqu" +
                    "aresOfDifferences = values.Select(val => (val - average) * (val - average)).Sum(" +
                    ");\r\n            double standardDeviation = Math.Sqrt(sumOfSquaresOfDifferences /" +
                    " (values.Count() - 1));\r\n            return standardDeviation;\r\n        }\r\n\r\n   " +
                    "     public static double CalculateConfidenceInterval95(IEnumerable<double> valu" +
                    "es)\r\n        {\r\n            double confidenceInterval95 = 1.96 * CalculateStanda" +
                    "rdDeviation(values) / Math.Sqrt((values.Count() - 1));\r\n            return confi" +
                    "denceInterval95;\r\n        }\r\n\r\n        public static void PrintClusteringMetrics" +
                    "(string name, ClusteringMetrics metrics)\r\n        {\r\n            Console.WriteLi" +
                    "ne($\"*************************************************\");\r\n            Console.W" +
                    "riteLine($\"*       Metrics for {name} clustering model      \");\r\n            Con" +
                    "sole.WriteLine($\"*------------------------------------------------\");\r\n         " +
                    "   Console.WriteLine($\"*       AvgMinScore: {metrics.AvgMinScore}\");\r\n          " +
                    "  Console.WriteLine($\"*       DBI is: {metrics.Dbi}\");\r\n            Console.Writ" +
                    "eLine($\"*************************************************\");\r\n        }\r\n\r\n     " +
                    "   public static List<TObservation> PeekDataViewInConsole<TObservation>(MLContex" +
                    "t mlContext, IDataView dataView, IEstimator<ITransformer> pipeline, int numberOf" +
                    "Rows = 4)\r\n            where TObservation : class, new()\r\n        {\r\n           " +
                    " string msg = string.Format(\"Peek data in DataView: Showing {0} rows with the co" +
                    "lumns specified by TObservation class\", numberOfRows.ToString());\r\n            C" +
                    "onsoleWriteHeader(msg);\r\n\r\n            //https://github.com/dotnet/machinelearni" +
                    "ng/blob/master/docs/code/MlNetCookBook.md#how-do-i-look-at-the-intermediate-data" +
                    "\r\n            var transformer = pipeline.Fit(dataView);\r\n            var transfo" +
                    "rmedData = transformer.Transform(dataView);\r\n\r\n            // \'transformedData\' " +
                    "is a \'promise\' of data, lazy-loading. Let\'s actually read it.\r\n            // Co" +
                    "nvert to an enumerable of user-defined type.\r\n            var someRows = transfo" +
                    "rmedData.AsEnumerable<TObservation>(mlContext, reuseRowObject: false)\r\n         " +
                    "                                  // Take the specified number of rows\r\n        " +
                    "                                   .Take(numberOfRows)\r\n                        " +
                    "                   // Convert to List\r\n                                         " +
                    "  .ToList();\r\n\r\n            someRows.ForEach(row =>\r\n            {\r\n            " +
                    "    string lineToPrint = \"Row--> \";\r\n\r\n                var fieldsInRow = row.Get" +
                    "Type().GetFields(BindingFlags.Instance |\r\n                                      " +
                    "                    BindingFlags.Static |\r\n                                     " +
                    "                     BindingFlags.NonPublic |\r\n                                 " +
                    "                         BindingFlags.Public);\r\n                foreach (FieldIn" +
                    "fo field in fieldsInRow)\r\n                {\r\n                    lineToPrint += " +
                    "$\"| {field.Name}: {field.GetValue(row)}\";\r\n                }\r\n                Co" +
                    "nsole.WriteLine(lineToPrint);\r\n            });\r\n\r\n            return someRows;\r\n" +
                    "        }\r\n\r\n        public static List<float[]> PeekVectorColumnDataInConsole(M" +
                    "LContext mlContext, string columnName, IDataView dataView, IEstimator<ITransform" +
                    "er> pipeline, int numberOfRows = 4)\r\n        {\r\n            string msg = string." +
                    "Format(\"Peek data in DataView: : Show {0} rows with just the \'{1}\' column\", numb" +
                    "erOfRows, columnName);\r\n            ConsoleWriteHeader(msg);\r\n\r\n            var " +
                    "transformer = pipeline.Fit(dataView);\r\n            var transformedData = transfo" +
                    "rmer.Transform(dataView);\r\n\r\n            // Extract the \'Features\' column.\r\n    " +
                    "        var someColumnData = transformedData.GetColumn<float[]>(mlContext, colum" +
                    "nName)\r\n                                                        .Take(numberOfRo" +
                    "ws).ToList();\r\n\r\n            // print to console the peeked rows\r\n            so" +
                    "meColumnData.ForEach(row =>\r\n            {\r\n                String concatColumn " +
                    "= String.Empty;\r\n                foreach (float f in row)\r\n                {\r\n  " +
                    "                  concatColumn += f.ToString();\r\n                }\r\n            " +
                    "    Console.WriteLine(concatColumn);\r\n            });\r\n\r\n            return some" +
                    "ColumnData;\r\n        }\r\n\r\n        public static void ConsoleWriteHeader(params s" +
                    "tring[] lines)\r\n        {\r\n            var defaultColor = Console.ForegroundColo" +
                    "r;\r\n            Console.ForegroundColor = ConsoleColor.Yellow;\r\n            Cons" +
                    "ole.WriteLine(\" \");\r\n            foreach (var line in lines)\r\n            {\r\n   " +
                    "             Console.WriteLine(line);\r\n            }\r\n            var maxLength " +
                    "= lines.Select(x => x.Length).Max();\r\n            Console.WriteLine(new string(\'" +
                    "#\', maxLength));\r\n            Console.ForegroundColor = defaultColor;\r\n        }" +
                    "\r\n\r\n        public static void ConsoleWriterSection(params string[] lines)\r\n    " +
                    "    {\r\n            var defaultColor = Console.ForegroundColor;\r\n            Cons" +
                    "ole.ForegroundColor = ConsoleColor.Blue;\r\n            Console.WriteLine(\" \");\r\n " +
                    "           foreach (var line in lines)\r\n            {\r\n                Console.W" +
                    "riteLine(line);\r\n            }\r\n            var maxLength = lines.Select(x => x." +
                    "Length).Max();\r\n            Console.WriteLine(new string(\'-\', maxLength));\r\n    " +
                    "        Console.ForegroundColor = defaultColor;\r\n        }\r\n\r\n        public sta" +
                    "tic void ConsolePressAnyKey()\r\n        {\r\n            var defaultColor = Console" +
                    ".ForegroundColor;\r\n            Console.ForegroundColor = ConsoleColor.Green;\r\n  " +
                    "          Console.WriteLine(\" \");\r\n            Console.WriteLine(\"Press any key " +
                    "to finish.\");\r\n            Console.ReadKey();\r\n        }\r\n\r\n        public stati" +
                    "c void ConsoleWriteException(params string[] lines)\r\n        {\r\n            var " +
                    "defaultColor = Console.ForegroundColor;\r\n            Console.ForegroundColor = C" +
                    "onsoleColor.Red;\r\n            const string exceptionTitle = \"EXCEPTION\";\r\n      " +
                    "      Console.WriteLine(\" \");\r\n            Console.WriteLine(exceptionTitle);\r\n " +
                    "           Console.WriteLine(new string(\'#\', exceptionTitle.Length));\r\n         " +
                    "   Console.ForegroundColor = defaultColor;\r\n            foreach (var line in lin" +
                    "es)\r\n            {\r\n                Console.WriteLine(line);\r\n            }\r\n   " +
                    "     }\r\n\r\n        public static void ConsoleWriteWarning(params string[] lines)\r" +
                    "\n        {\r\n            var defaultColor = Console.ForegroundColor;\r\n           " +
                    " Console.ForegroundColor = ConsoleColor.DarkMagenta;\r\n            const string w" +
                    "arningTitle = \"WARNING\";\r\n            Console.WriteLine(\" \");\r\n            Conso" +
                    "le.WriteLine(warningTitle);\r\n            Console.WriteLine(new string(\'#\', warni" +
                    "ngTitle.Length));\r\n            Console.ForegroundColor = defaultColor;\r\n        " +
                    "    foreach (var line in lines)\r\n            {\r\n                Console.WriteLin" +
                    "e(line);\r\n            }\r\n        }\r\n\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class ConsoleHelperBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
