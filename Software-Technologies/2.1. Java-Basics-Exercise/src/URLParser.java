import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String url = scan.nextLine();
        String protocol = "";
        String server = "";
        String resource = "";

        int indexOfProtocol = url.indexOf("://");

        if (indexOfProtocol != -1){
            protocol = url.substring(0, indexOfProtocol);
            url = url.substring(indexOfProtocol + 3);
        }

        int indexOfRightPart = url.indexOf("/");

        if (indexOfRightPart != -1){
            server = url.substring(0, indexOfRightPart);
            resource = url.substring(indexOfRightPart + 1);
        }
        else
        {
            server = url;
        }
        System.out.println("[protocol] = " + "\"" + protocol + "\"");
        System.out.println("[server] = " + "\"" + server + "\"");
        System.out.println("[resource] = " + "\"" + resource + "\"");
    }
}
