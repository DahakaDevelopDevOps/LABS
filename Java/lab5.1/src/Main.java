import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Semaphore;
import java.util.concurrent.TimeUnit;
import java.util.logging.Level;
import java.util.logging.Logger;
public class Main {
    public static void main(String[] args) {
        final int NUM_CARS = 10; // number of cars to park
        ExecutorService executorService = Executors.newFixedThreadPool(NUM_CARS);
        ParkingLot parkingLot = new ParkingLot();
        for (int i = 0; i < NUM_CARS; i++) {
            int id = i + 1;
            executorService.submit(() -> parkingLot.parkCar(id));
        }
        executorService.shutdown();
        try {
            executorService.awaitTermination(1, TimeUnit.MINUTES);
        } catch (InterruptedException ex) {
            System.out.println("Interrupted while waiting for cars to park");
            Thread.currentThread().interrupt();
        }
        System.out.println("All cars have parked");
    }
}