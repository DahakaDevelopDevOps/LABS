import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.*;
public class WebResourceConnection {
    public static void main(String[] args) {
        try {
            URL url = new URL("http://example.com"); // replace with the URL of the web resource you want to connect to
            HttpURLConnection con = (HttpURLConnection) url.openConnection();
            con.setRequestMethod("GET"); // set the request method, e.g. GET or POST
            int status = con.getResponseCode(); // get the HTTP response code
            System.out.println("Response code: " + status);

            BufferedReader in = new BufferedReader(
                    new InputStreamReader(con.getInputStream())); // get the response data
            String inputLine;
            StringBuffer content = new StringBuffer();
            while ((inputLine = in.readLine()) != null) {
                content.append(inputLine); // store the response data
            }
            in.close();

            System.out.println("Response content: " + content.toString()); // print the response data
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
