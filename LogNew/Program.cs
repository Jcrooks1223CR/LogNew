using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Reflection.Emit;
using static System.Net.WebRequestMethods;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Runtime;
using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;
using File = System.IO.File;
using static System.Net.Mime.MediaTypeNames;

namespace NewLog
{

    public class LogDataTransport
    {
        public static void Main(string[] args)
        {
            var logData = File.ReadAllText(@".\logData.json");
            var logconfig = File.ReadAllText(@".\logconfig.json");
            string logFile = File.ReadAllText(@".\logfile.log");


            string logMessage = "This is a newer test log message.\n";
            Console.WriteLine(logMessage);
            //Console.WriteLine(logconfig);
            //Console.WriteLine(logData);
            //Console.WriteLine(logMessage);
            ToConsole(logMessage);

            static void ToConsole(string logMessage)
            {

                var logconfig = File.ReadAllText(@".\logconfig.json");
                string logFile = File.ReadAllText(@".\logfile.log");
                // GetLogData logData = new GetLogData();
                //string[] logMessage = { logData.GetTimeStamp, logData.GetHost, logData.GetSource, logData.GetCorrelationId, logData.GetCode, logData.GetMessage, logData.GetTrace };

                if (string.IsNullOrEmpty(logMessage))
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Console Log Data: ", logMessage);
                }


            }


            /* static void ToFile(string logMessage)
             {
                 var logconfig = File.ReadAllText(@".\logconfig.json");
                 string logFile = File.ReadAllText(@".\logfile.json");
                 GetLogData logData = new GetLogData();
                 string[] logMessage = { logData.GetTimeStamp, logData.GetHost, logData.GetSource, logData.GetCorrelationId, logData.GetCode, logData.GetMessage, logData.GetTrace };

                 if (!string.IsNullOrEmpty(logMessage))
                 {
                     Environment.Exit(0);
                 }
                 else
                 {
                     // When appendFile is called and logFile.log doesn't exist, the file will be created by the function

                     using (StreamWriter ReadLogFile = File.AppendText(logFile))
                     {
                         ReadLogFile.Write("END");
                     }
                     string logText = File.ReadAllText(logFile);

                     if (logText != null)
                     {
                         throw new Exception(text);
                     }
                     Console.WriteLine(text);

                     Console.WriteLine("The string was successfully appended to the file!");
                 }
                 return logMessage;
             }*/

            /* void ToAPI(string logMessage)
             {
                 GetLogData logData = new GetLogData();
                 string[] logMessage = { logData.GetTimeStamp, logData.GetHost, logData.GetSource, logData.GetCorrelationId, logData.GetCode, logData.GetMessage, logData.GetTrace };
                 string logMessage = `< error >

                            < parameter name = "severity" >${ recordlevel}</ parameter >

                            < parameter name = "host" >${ host}</ parameter >

                            < parameter name = "source" >${ source}</ parameter >

                            < parameter name = "message" >${ code} - ${ message}</ parameter >`;


                 if (logData.GetCorrelationId || logData.GetHttp || data) {
                     let notes = ``;

                     if (logData.GetCorrelationId)
                     {
                        string notes += `correlationid - ${ logData.GetCorrelationId}`;
                     }
                     else
                     {
                         notes += 'no correlation id provided';
                     }

                     if (http)
                     {
                         if (logData.GetHttp.request || http?.response) {
                             notes += '\n\nHTTP RESPONSE';

                             if (http?.response?.status) {
                                 notes += `\nSTATUS\n${ http.response.status}`;
                             } else {
                                 notes += '\nSTATUS\nnone';
                             }

                             if (http?.response?.headers) {
                                 notes += `\nHEADERS\n${ http.response.headers}`;
                             } else {
                                 notes += '\nHEADERS\nnone';
                             }

                             if (http?.response?.data) {
                                 notes += `\nDATA\n${ http.response.data}`;
                             } else {
                                 notes += '\nDATA\nnone';
                             }

                             notes += '\nHTTP REQUEST';

                             if (http?.request?.headers) {
                                 notes += `\nHEADERS\n${ http.request.headers}`;
                             } else {
                                 notes += '\nHEADERS\nnone';
                             }

                             if (http?.request?.data) {
                                 notes += `\nDATA\n${ http.request.data}`;
                             } else {
                                 notes += '\nDATA\nnone';
                             }
                         }
                     }

                     if (transaction?.trace) {
                         notes += `\n${ transaction.trace}`;
                     }

                     if (data) {
                         notes += `\nDATA\n${ data}`;
                     }

                     notes = notes.replace(/</ g, '*').replace(/>/ g, '*');
                     logMessage += `< parameter name = "notes" >${ notes}</ parameter >`;
                 }

                 if (trace)
                 {
                     const stacktrace = trace.replace(/</ g, '*').replace(/>/ g, '*');
                     logMessage += `< parameter name = "stacktrace" >${ stacktrace}</ parameter >`;
                 }

                 if (transaction?.route) {
                     logMessage += `< parameter name = "requestURL" >${ transaction.route}</ parameter >`;
                 }

                 logMessage += `</ error >`;

                 //console.log(logMessage);
                 return logMessage;
             }*/

            /* async forDB(level, logData)
              {

               this function should define the format for a log Data when published to the console.
               this format will be standard for all log publishing to a database as part of this
               solution.


                  // not configured at this time - Michael Hebert - 2023-05-30

                  if (!level || !logData)
                  {
                      // log logger error to default logger file
                      exit;
                  }

                  return logMessage;
              }*/
        }
    }
}
