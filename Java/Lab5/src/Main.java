import java.io.Console;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;
import java.util.logging.Level;
import java.util.logging.Logger;


public class Main {
    public static void main(String[] args) {
        final int NUM_OPERATORS = 5; // number of operators
        final int MAX_WAIT_TIME = 10; // maximum wait time for a call in seconds
        final int NUM_CALLS = 10; // number of calls to simulate
        ExecutorService executorService = Executors.newFixedThreadPool(NUM_OPERATORS);
        CallCenter callCenter = new CallCenter();
        for (int i = 0; i < NUM_CALLS; i++) {
            final int id = i + 1;
            executorService.submit(() -> callCenter.makeCall(id));
        }
        executorService.shutdown();
        try {
            executorService.awaitTermination(Long.MAX_VALUE, TimeUnit.NANOSECONDS);
        } catch (InterruptedException ex) {
            System.out.println("Exception");
        }
    }
}