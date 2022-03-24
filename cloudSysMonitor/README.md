This app is used to capture system hardware info and track its usage by sending telemetry to Azure IoT for analysis.
This data comes from Performance Counters using Windows Management Instrumentation and can be compared to the Windows Task Manager to ensure its readings are accurate.

Use "Get Info" to get information on current hardware installed on the computer.
Use "Get Performance to get performance metrics on disk drive, CPU, and RAM usage.

Telemetry is sent once "Get Performance" button is clicked. You can view the details of each message on the console.
You can view telemetry received using Azure IoT Explorer.

If you want the app to work with your own device, simply replace the device connection string with your own and run the app. 

Recent Updates

V2.0.12 - Stable (latest release) - made corrections to UI
About section was fixed. The debug and release sections were fixed as well.

V2.01 release - Minor changes
Official release version. Project was built as .exe executable file. Located in cloudSysMonitor\bin\Release\net6.0-windows. Keep in mind the files inside the folder are required to run the executable.

V2.0 debug - Major changes
Included Azure IoT functionality. Simply replace the device connection string with your own and run. Reduced file size and removed unnecessary code.

V1.0 Initial Commit - Captured hardware info with "Get Info" and performance metrics with "Get Performance".
