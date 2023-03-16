import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Semaphore;
import java.util.concurrent.TimeUnit;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ParkingLot {
    private static final int NUM_PARKING_SPACES_A = 5; // number of parking spaces in lot A
    private static final int NUM_PARKING_SPACES_B = 7; // number of parking spaces in lot B
    private static final int MAX_WAIT_TIME = 5; // maximum wait time for a car in seconds
    private static final int NUM_CARS = 10; // number of cars to park
    private static final Logger LOGGER = Logger.getLogger(ParkingLot.class.getName());

    private final Semaphore parkingSpacesA = new Semaphore(NUM_PARKING_SPACES_A);
    private final Semaphore parkingSpacesB = new Semaphore(NUM_PARKING_SPACES_B);

    public void parkCar(int id) {
        try {
            boolean parked = false;
            while (!parked) {
                // try to acquire a parking space in lot A
                if (parkingSpacesA.tryAcquire()) {
                    LOGGER.log(Level.INFO, "Car {0} parked in lot A. Spaces available: {1}/{2}", new Object[]{id, parkingSpacesA.availablePermits(), NUM_PARKING_SPACES_A});
                    Thread.sleep((int) (Math.random() * MAX_WAIT_TIME) + 1);
                    parkingSpacesA.release();
                    LOGGER.log(Level.INFO, "Car {0} left lot A. Spaces available: {1}/{2}", new Object[]{id, parkingSpacesA.availablePermits(), NUM_PARKING_SPACES_A});
                    parked = true;
                } else {
                    LOGGER.log(Level.INFO, "Car {0} waiting for a parking space in lot A. Spaces available: {1}/{2}", new Object[]{id, parkingSpacesA.availablePermits(), NUM_PARKING_SPACES_A});
                }

                // try to acquire a parking space in lot B
                if (!parked && parkingSpacesB.tryAcquire()) {
                    LOGGER.log(Level.INFO, "Car {0} parked in lot B. Spaces available: {1}/{2}", new Object[]{id, parkingSpacesB.availablePermits(), NUM_PARKING_SPACES_B});
                    Thread.sleep((int) (Math.random() * MAX_WAIT_TIME) + 1);
                    parkingSpacesB.release();
                    LOGGER.log(Level.INFO, "Car {0} left lot B. Spaces available: {1}/{2}", new Object[]{id, parkingSpacesB.availablePermits(), NUM_PARKING_SPACES_B});
                    parked = true;
                } else {
                    LOGGER.log(Level.INFO, "Car {0} waiting for a parking space in lot B. Spaces available: {1}/{2}", new Object[]{id, parkingSpacesB.availablePermits(), NUM_PARKING_SPACES_B});
                }

                // if the car hasn't parked yet, wait and try again
                if (!parked) {
                    LOGGER.log(Level.INFO, "Car {0} couldn't find a parking space. Retrying...", id);
                    Thread.sleep(1000);
                }
            }
        } catch (InterruptedException ex) {
            LOGGER.log(Level.SEVERE, "Car {0} interrupted", id);
            Thread.currentThread().interrupt();
        }
    }
}