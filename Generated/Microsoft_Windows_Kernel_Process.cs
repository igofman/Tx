// 
//    This code was generated by EtwEventTypeGen.exe 
//

using System;

namespace Tx.Windows.Microsoft_Windows_Kernel_Process
{
    [Format("Process %1 started at time %2 by parent %3 running in session %4 with name %5.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 1, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_PROCESS")]

    public class ProcessStart_V0 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:FILETIME")]
        public DateTime CreateTime { get; set; }

        [EventField("win:UInt32")]
        public uint ParentProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint SessionID { get; set; }

        [EventField("win:UnicodeString")]
        public string ImageName { get; set; }
    }

    [Format("Process %1 started at time %2 by parent %3 running in session %4 with name %6.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 1, 1,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_PROCESS")]

    public class ProcessStart_V1 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:FILETIME")]
        public DateTime CreateTime { get; set; }

        [EventField("win:UInt32")]
        public uint ParentProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint SessionID { get; set; }

        [EventField("win:UInt32")]
        public uint Flags { get; set; }

        [EventField("win:UnicodeString")]
        public string ImageName { get; set; }
    }

    [Format("Process %1 (which started at time %2) stopped at time %3 with exit code %4.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 2, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_PROCESS")]

    public class ProcessStop_V0 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:FILETIME")]
        public DateTime CreateTime { get; set; }

        [EventField("win:FILETIME")]
        public DateTime ExitTime { get; set; }

        [EventField("win:UInt32")]
        public uint ExitCode { get; set; }

        [EventField("win:UInt32")]
        public uint TokenElevationType { get; set; }

        [EventField("win:UInt32")]
        public uint HandleCount { get; set; }

        [EventField("win:UInt64")]
        public ulong CommitCharge { get; set; }

        [EventField("win:UInt64")]
        public ulong CommitPeak { get; set; }

        [EventField("win:AnsiString")]
        public string ImageName { get; set; }
    }

    [Format("Process %1 (which started at time %2) stopped at time %3 with exit code %4.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 2, 1,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_PROCESS")]

    public class ProcessStop_V1 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:FILETIME")]
        public DateTime CreateTime { get; set; }

        [EventField("win:FILETIME")]
        public DateTime ExitTime { get; set; }

        [EventField("win:UInt32")]
        public uint ExitCode { get; set; }

        [EventField("win:UInt32")]
        public uint TokenElevationType { get; set; }

        [EventField("win:UInt32")]
        public uint HandleCount { get; set; }

        [EventField("win:UInt64")]
        public ulong CommitCharge { get; set; }

        [EventField("win:UInt64")]
        public ulong CommitPeak { get; set; }

        [EventField("win:UInt64")]
        public ulong CPUCycleCount { get; set; }

        [EventField("win:UInt32")]
        public uint ReadOperationCount { get; set; }

        [EventField("win:UInt32")]
        public uint WriteOperationCount { get; set; }

        [EventField("win:UInt32")]
        public uint ReadTransferKiloBytes { get; set; }

        [EventField("win:UInt32")]
        public uint WriteTransferKiloBytes { get; set; }

        [EventField("win:UInt32")]
        public uint HardFaultCount { get; set; }

        [EventField("win:AnsiString")]
        public string ImageName { get; set; }
    }

    [Format("Thread %2 (in Process %1) started.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 3, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_THREAD")]

    public class ThreadStart_V0 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:Pointer")]
        public ulong StackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong StackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong Win32StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong TebBase { get; set; }
    }

    [Format("Thread %2 (in Process %1) started.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 3, 1,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_THREAD")]

    public class ThreadStart_V1 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:Pointer")]
        public ulong StackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong StackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong Win32StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong TebBase { get; set; }

        [EventField("win:UInt32")]
        public uint SubProcessTag { get; set; }
    }

    [Format("Thread %2 (in Process %1) stopped.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 4, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_THREAD")]

    public class ThreadStop_V0 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:Pointer")]
        public ulong StackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong StackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong Win32StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong TebBase { get; set; }
    }

    [Format("Thread %2 (in Process %1) stopped.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 4, 1,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_THREAD")]

    public class ThreadStop_V1 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:Pointer")]
        public ulong StackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong StackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong Win32StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong TebBase { get; set; }

        [EventField("win:UInt32")]
        public uint SubProcessTag { get; set; }

        [EventField("win:UInt64")]
        public ulong CycleTime { get; set; }
    }

    [Format("Process %3 had an image loaded with name %7.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 5, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_IMAGE")]

    public class ImageLoad : SystemEvent
    {
        [EventField("win:Pointer")]
        public ulong ImageBase { get; set; }

        [EventField("win:Pointer")]
        public ulong ImageSize { get; set; }

        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ImageCheckSum { get; set; }

        [EventField("win:UInt32")]
        public uint TimeDateStamp { get; set; }

        [EventField("win:Pointer")]
        public ulong DefaultBase { get; set; }

        [EventField("win:UnicodeString")]
        public string ImageName { get; set; }
    }

    [Format("Process %3 had an image unloaded with name %7.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 6, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_IMAGE")]

    public class ImageUnload : SystemEvent
    {
        [EventField("win:Pointer")]
        public ulong ImageBase { get; set; }

        [EventField("win:Pointer")]
        public ulong ImageSize { get; set; }

        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ImageCheckSum { get; set; }

        [EventField("win:UInt32")]
        public uint TimeDateStamp { get; set; }

        [EventField("win:Pointer")]
        public ulong DefaultBase { get; set; }

        [EventField("win:UnicodeString")]
        public string ImageName { get; set; }
    }

    [Format("Base CPU priority of thread %2 in process %1 was changed from %3 to %4.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 7, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_CPU_PRIORITY")]

    public class ThreadCpuBasePriorityChange : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:UInt8")]
        public byte OldPriority { get; set; }

        [EventField("win:UInt8")]
        public byte NewPriority { get; set; }
    }

    [Format("CPU priority of thread %2 in process %1 was changed from %3 to %4.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 8, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_CPU_PRIORITY")]

    public class ThreadCpuPriorityChange : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:UInt8")]
        public byte OldPriority { get; set; }

        [EventField("win:UInt8")]
        public byte NewPriority { get; set; }
    }

    [Format("Page priority of thread %2 in process %1 was changed from %3 to %4.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 9, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_OTHER_PRIORITY")]

    public class ThreadPagePriorityChange : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:UInt8")]
        public byte OldPriority { get; set; }

        [EventField("win:UInt8")]
        public byte NewPriority { get; set; }
    }

    [Format("I/O priority of thread %2 in process %1 was changed from %3 to %4.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 10, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_OTHER_PRIORITY")]

    public class ThreadIoPriorityChange : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:UInt8")]
        public byte OldPriority { get; set; }

        [EventField("win:UInt8")]
        public byte NewPriority { get; set; }
    }

    [Format("Execution of the process %1 has been suspended.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 11, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_PROCESS_FREEZE")]

    public class ProcessFreezeEvent : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint FrozenProcessID { get; set; }
    }

    [Format("Execution of the process %1 has been resumed.")]

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 12, 0,
    "", "win:Informational", "Microsoft-Windows-Kernel-Process/Analytic", "WINEVENT_KEYWORD_PROCESS_FREEZE")]

    public class ProcessThawEvent : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint FrozenProcessID { get; set; }
    }

}
