import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;
import java.util.logging.Level;
import java.util.logging.Logger;

public class CallCenter {
        private static final int NUM_OPERATORS = 5; // number of operators
        private static final int MAX_WAIT_TIME = 10; // maximum wait time for a call in seconds
        private static final int NUM_CALLS = 10; // number of calls to simulate
        private static final Logger LOGGER = Logger.getLogger(CallCenter.class.getName());

        private final Lock lock = new ReentrantLock();
        private int operatorsAvailable = NUM_OPERATORS;
        public void handleCall(int id) {
                try {
                        // simulate a call by sleeping for a random amount of time
                        int duration = (int) (Math.random() * MAX_WAIT_TIME) + 1;
                        LOGGER.log(Level.INFO, "Call {0} started. Expected duration: {1} seconds", new Object[]{id, duration});
                        Thread.sleep(duration * 1000);

                        // call finished, release operator
                        lock.lock();
                        try {
                                operatorsAvailable++;
                                LOGGER.log(Level.INFO, "Call {0} finished. Operator released. Operators available: {1}", new Object[]{id, operatorsAvailable});
                        } finally {
                                lock.unlock();
                        }
                } catch (InterruptedException ex) {
                        LOGGER.log(Level.SEVERE, "Call {0} interrupted", id);
                        Thread.currentThread().interrupt();
                }
        }

        public void makeCall(int id) {
                lock.lock();
                try {
                        while (operatorsAvailable <= 0) {
                                LOGGER.log(Level.INFO, "Call {0} waiting. All operators busy. Operators available: {1}", new Object[]{id, operatorsAvailable});
                                lock.unlock();
                                Thread.sleep(1000);
                                lock.lock();
                        }
                        operatorsAvailable--;
                        LOGGER.log(Level.INFO, "Call {0} connected. Operators available: {1}", new Object[]{id, operatorsAvailable});
                } catch (InterruptedException ex) {
                        LOGGER.log(Level.SEVERE, "Call {0} interrupted", id);
                        Thread.currentThread().interrupt();
                } finally {
                        lock.unlock();
                }

                // handle the call
                handleCall(id);
        }
    }
