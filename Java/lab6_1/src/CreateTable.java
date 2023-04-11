import java.sql.*;

public class CreateTable {
    static final String JDBC_DRIVER = " com.microsoft.sqlserver.jdbc.SQLServerDriver";
    static final String DB_URL = "jdbc:sqlserver://DESKTOP-7RN3CKK:1433;databaseName=Souvenirs;trustServerCertificate=true;encrypt=false;IntegratedSecurity=false";

    static final String USER = "sa";
    static final String PASS = "1111";

    public static void main(String[] args) {
        Connection conn = null;
        Statement stmt = null;
        try {
            // Register JDBC driver
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");

            // Open a connection
            System.out.println("Connecting to database...");
            conn = DriverManager.getConnection(DB_URL, USER, PASS);

            // Execute a query to create a table
            System.out.println("Creating table in given database...");
            stmt = conn.createStatement();
            /**    String sql = "ALTER TABLE SOUVENIRS " +
             "(Title VARCHAR(50), " +
             " Producer_requisite VARCHAR(50)," +
             "Date_of_issue DATE, " +
             " Producer VARCHAR(50), " +
             " Price  DECIMAL)";*/
            String sql = "CREATE TABLE MANUFACTURER " +
                    "(prodname VARCHAR(50) primary key , " +
                    " Country  VARCHAR(50))";
            stmt.executeUpdate(sql);
            System.out.println("Table created successfully...");
        }
        catch (SQLException se) {
            // Handle errors for JDBC
            se.printStackTrace();
        } catch (Exception e) {
            // Handle errors for Class.forName
            e.printStackTrace();

        } finally {
            // finally block used to close resources
            try {
                if (stmt != null) {
                    conn.close();
                }
            } catch (SQLException se) {
            } // do nothing
            try {
                if (conn != null) {
                    conn.close();
                }
            } catch (SQLException se) {
                se.printStackTrace();
            } // end finally try
        } // end try
        System.out.println("Goodbye!");

    } // end main
} // end CreateTable
