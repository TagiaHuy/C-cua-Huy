// Bài tập 79.
// Biến đổi bài minh họa, slide5  Chương 8:
// Trong C# đặt lệnh thực hiện hàm static sau trong 1 thread:
// static void DoWork() {
//        for (int i = 0; i < 5; i++) {
//            Console.WriteLine("Worker thread: " + i);
//         Thread.Sleep(100); // Pause the worker thread for 100ms
//       } 
// }

using System;
using System.Threading;
class Program {
    static void DoWork() {
       for (int i = 0; i < 5; i++) {
           Console.WriteLine("Worker thread: " + i);
        Thread.Sleep(100); // Pause the worker thread for 100ms
        } 
    }
    static void Main() {
    // Create a new thread and assign the DoWork method to execute
    Thread thread = new Thread(new ThreadStart(DoWork));
    thread.Start();
    // Main thread continues to run
    for (int i = 0; i < 5; i++) {
    Console.WriteLine("Main thread: " + i);
    Thread.Sleep(100); // Pause the main thread for 100ms
    }
    // Wait for the worker thread to finish
    thread.Join(); 
} } 
