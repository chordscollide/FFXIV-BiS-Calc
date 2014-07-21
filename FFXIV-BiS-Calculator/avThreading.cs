using System;
using System.Collections.Generic;
using System.Threading;

namespace avThreading {
  /// <summary>
  /// delegate for "for" thread
  /// </summary>
  /// <param name="start"></param>
  /// <param name="end"></param>
  public delegate void avForThreadDeleg(int start, int end);

  /// <summary>
  /// avForThread is a very simple version of the kind of operations possible with OpenMP 
  /// eg:
  ///    int [] data = new int[1000];
  ///    using( new avForThread( 0, 1000, 4, 
  ///       delegate( int start, int end )
  ///       {
  ///            for( int i=start; i (lessthan) end; i++)
  ///            {
  ///                 data[i] = calculateSomething(i);
  ///				}
  ///		  })
  /// 	  );
  /// 
  /// </summary>
  public class avForThread : IDisposable {
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="start">the starting value range</param>
    /// <param name="end">the neding value range</param>
    /// <param name="numThreads">the number of threads to use</param>
    /// <param name="deleg">the function to call</param>
    public avForThread(int start, int end, int numThreads, avForThreadDeleg deleg) {
      Threads = new Thread[numThreads];
      Deleg = deleg;
      threadDone = new bool[numThreads];
      for (int i = 0; i < numThreads; i++) {

        Threads[i] = new Thread(startThread);

        int steps = (end - start);
        int tStart = (i * steps) / numThreads;
        int tEnd = ((i + 1) * steps) / numThreads; // Yep.......
        //int tEnd = ((i + 1) * steps) / numThreads - 1;

        Threads[i].Start(new int[] { tStart, tEnd });
      }
    }


    /// <summary>
    /// dont call this
    /// </summary>
    public void Dispose() {
      if (!disposed)
        WaitToFinish();
      disposed = true;
    }

    public void WaitToFinish() {
      if (disposed) return;

      bool done = false;
      int nThread = Threads.Length;
      while (!done) {
        done = true;
        for (int i = 0; i < nThread; i++)
          if (!threadDone[i]) {
            if (Threads[i].IsAlive) {
              done = false;
              break;
            } else
              threadDone[i] = true;
          }
        Thread.Sleep(4);
      }	
    }

    #region privates
    void startThread(object o) {
      int[] startEnd = o as int[];
      Deleg(startEnd[0], startEnd[1]);
    }
    avForThreadDeleg Deleg;
    bool disposed;
    bool[] threadDone;
    Thread[] Threads;
    #endregion
  }
}