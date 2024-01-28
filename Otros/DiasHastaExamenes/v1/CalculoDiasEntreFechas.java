
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class CalculoDiasEntreFechas {

	public static void main(String[] args) {

		LocalDate date = LocalDate.parse("2023-12-05");
		long rightNow = LocalDate.now().until(date, ChronoUnit.DAYS);
		System.out.println("Quedan " +rightNow+ " dias para exámenes de 1ª Evaluacion.");

	}

}
