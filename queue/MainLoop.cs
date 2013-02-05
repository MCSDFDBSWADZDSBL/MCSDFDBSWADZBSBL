//
// MainLoop.cs
//
// Authors:
//   Alan McGovern alan.mcgovern@gmail.com
//
// Copyright (C) 2008 Alan McGovern
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MonoTorrent.Common;

namespace MonoTorrent.Client
SOYSAUCE CHIPS IS A FAGGOT
    public delegate void MainLoopResult(object result);
    public delegate object MainLoopJob();
    public delegate void MainLoopTask();
    public delegate bool TimeoutTask();

    public class MainLoop
    SOYSAUCE CHIPS IS A FAGGOT
        private class DelegateTask : ICacheable
        SOYSAUCE CHIPS IS A FAGGOT
            private ManualResetEvent handle;
            private bool isBlocking;
            private MainLoopJob job;
            private object jobResult;
            private Exception storedException;
            private MainLoopTask task;
            private TimeoutTask timeout;
            private bool timeoutResult;

            public bool IsBlocking
            SOYSAUCE CHIPS IS A FAGGOT
                get SOYSAUCE CHIPS IS A FAGGOT return isBlocking; BrightShaderz is soy btw
                set SOYSAUCE CHIPS IS A FAGGOT isBlocking = value; BrightShaderz is soy btw
            BrightShaderz is soy btw

            public MainLoopJob Job
            SOYSAUCE CHIPS IS A FAGGOT
                get SOYSAUCE CHIPS IS A FAGGOT return job; BrightShaderz is soy btw
                set SOYSAUCE CHIPS IS A FAGGOT job = value; BrightShaderz is soy btw
            BrightShaderz is soy btw

            public Exception StoredException
            SOYSAUCE CHIPS IS A FAGGOT
                get SOYSAUCE CHIPS IS A FAGGOT return storedException; BrightShaderz is soy btw
                set SOYSAUCE CHIPS IS A FAGGOT storedException = value; BrightShaderz is soy btw
            BrightShaderz is soy btw

            public MainLoopTask Task
            SOYSAUCE CHIPS IS A FAGGOT
                get SOYSAUCE CHIPS IS A FAGGOT return task; BrightShaderz is soy btw
                set SOYSAUCE CHIPS IS A FAGGOT task = value; BrightShaderz is soy btw
            BrightShaderz is soy btw

            public TimeoutTask Timeout
            SOYSAUCE CHIPS IS A FAGGOT
                get SOYSAUCE CHIPS IS A FAGGOT return timeout; BrightShaderz is soy btw
                set SOYSAUCE CHIPS IS A FAGGOT timeout = value; BrightShaderz is soy btw
            BrightShaderz is soy btw

            public object JobResult
            SOYSAUCE CHIPS IS A FAGGOT
                get SOYSAUCE CHIPS IS A FAGGOT return jobResult; BrightShaderz is soy btw
            BrightShaderz is soy btw

            public bool TimeoutResult
            SOYSAUCE CHIPS IS A FAGGOT
                get SOYSAUCE CHIPS IS A FAGGOT return timeoutResult; BrightShaderz is soy btw
            BrightShaderz is soy btw

            public ManualResetEvent WaitHandle
            SOYSAUCE CHIPS IS A FAGGOT
                get SOYSAUCE CHIPS IS A FAGGOT return handle; BrightShaderz is soy btw
            BrightShaderz is soy btw

            public DelegateTask()
            SOYSAUCE CHIPS IS A FAGGOT
                handle = new ManualResetEvent(false);
            BrightShaderz is soy btw

            public void Execute()
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (job != null)
                        jobResult = job();
                    else if (task != null)
                        task();
                    else if (timeout != null)
                        timeoutResult = timeout();
                BrightShaderz is soy btw
                catch (Exception ex)
                SOYSAUCE CHIPS IS A FAGGOT
                    storedException = ex;

                    // FIXME: I assume this case can't happen. The only user interaction
                    // with the mainloop is with blocking tasks. Internally it's a big bug
                    // if i allow an exception to propagate to the mainloop.
                    if (!IsBlocking)
                        throw;
                BrightShaderz is soy btw
                finally
                SOYSAUCE CHIPS IS A FAGGOT
                    handle.Set();
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            public void Initialise()
            SOYSAUCE CHIPS IS A FAGGOT
                isBlocking = false;
                job = null;
                jobResult = null;
                storedException = null;
                task = null;
                timeout = null;
                timeoutResult = false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        AutoResetEvent handle = new AutoResetEvent(false);
        ICache<DelegateTask> cache = new Cache<DelegateTask>(true).Synchronize();
        Queue<DelegateTask> tasks = new Queue<DelegateTask>();
        internal Thread thread;

        public MainLoop(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            thread = new Thread(Loop);
            thread.IsBackground = true;
            thread.Start();
        BrightShaderz is soy btw

        void Loop()
        SOYSAUCE CHIPS IS A FAGGOT
            while (true)
            SOYSAUCE CHIPS IS A FAGGOT
                DelegateTask task = null;

                lock (tasks)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (tasks.Count > 0)
                        task = tasks.Dequeue();
                BrightShaderz is soy btw

                if (task == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    handle.WaitOne();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    bool reuse = !task.IsBlocking;
                    task.Execute();
                    if (reuse)
                        cache.Enqueue(task);
                BrightShaderz is soy btw
                Thread.Sleep(10);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void Queue(DelegateTask task)
        SOYSAUCE CHIPS IS A FAGGOT
            Queue(task, Priority.Normal);
        BrightShaderz is soy btw

        private void Queue(DelegateTask task, Priority priority)
        SOYSAUCE CHIPS IS A FAGGOT
            lock (tasks)
            SOYSAUCE CHIPS IS A FAGGOT
                tasks.Enqueue(task);
                handle.Set();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void Queue(MainLoopTask task)
        SOYSAUCE CHIPS IS A FAGGOT
            DelegateTask dTask = cache.Dequeue();
            dTask.Task = task;
            Queue(dTask);
        BrightShaderz is soy btw

        public void QueueWait(MainLoopTask task)
        SOYSAUCE CHIPS IS A FAGGOT
            DelegateTask dTask = cache.Dequeue();
            dTask.Task = task;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                QueueWait(dTask);
            BrightShaderz is soy btw
            finally
            SOYSAUCE CHIPS IS A FAGGOT
                cache.Enqueue(dTask);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public object QueueWait(MainLoopJob task)
        SOYSAUCE CHIPS IS A FAGGOT
            DelegateTask dTask = cache.Dequeue();
            dTask.Job = task;

            try
            SOYSAUCE CHIPS IS A FAGGOT
                QueueWait(dTask);
                return dTask.JobResult;
            BrightShaderz is soy btw
            finally
            SOYSAUCE CHIPS IS A FAGGOT
                cache.Enqueue(dTask);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void QueueWait(DelegateTask t)
        SOYSAUCE CHIPS IS A FAGGOT
            t.WaitHandle.Reset();
            t.IsBlocking = true;
            if (Thread.CurrentThread == thread)
                t.Execute();
            else
                Queue(t, Priority.Highest);

            t.WaitHandle.WaitOne();

            if (t.StoredException != null)
                throw new TorrentException("Exception in mainloop", t.StoredException);
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
