import java.awt.EventQueue;
import java.awt.TextArea;

import javax.swing.JFrame;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import javax.swing.JTextArea;
import javax.swing.JScrollPane;
import java.awt.Color;

public class MainVentana {

	private JFrame frame;
	private JTextField textField;
	private static BufferedWriter bufferedWriter;
	private static BufferedReader bufferedReader;
	private static JTextArea textArea;
	private static File file;

	public static void main(String[] args) throws IOException {
		// Archivo donde se guardarán los textos
		file = new File("libros.txt");
		// BufferedWriter para escribir en el archivo
		bufferedWriter = new BufferedWriter(new FileWriter(file, true));
		// BufferedReader para leer desde el archivo
		bufferedReader = new BufferedReader(new FileReader(file));

		// EventQueue para manejar la interfaz gráfica en un hilo aparte
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					// Crear la ventana principal
					MainVentana window = new MainVentana();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public MainVentana() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {

		// Configuración de la ventana principal
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		// Campo de texto para introducir texto
		textField = new JTextField();
		textField.setBounds(80, 94, 89, 20);
		frame.getContentPane().add(textField);
		textField.setColumns(10);

		// Etiqueta para indicar al usuario que introduzca un texto
		JLabel labelIntroduceUnTexto = new JLabel("INTRODUCE UN TEXTO: ");
		labelIntroduceUnTexto.setBounds(57, 69, 146, 14);
		frame.getContentPane().add(labelIntroduceUnTexto);

		// Botón para añadir texto al archivo
		JButton botonAnadir = new JButton("AÑADIR");
		botonAnadir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					// Verificar si el campo de texto no está vacío
					if (!textField.getText().isEmpty()) {
						// Escribir el texto en el archivo
						bufferedWriter.write(textField.getText() + "\n");
						// Mostrar mensaje de éxito
						JOptionPane.showMessageDialog(null, "El texto se ha añadido con éxito", "EXITO", 1);
					} else {
						// Mostrar mensaje de error si el campo de texto está vacío
						JOptionPane.showMessageDialog(null, "No se ha añadido ningún texto", "ERROR", 2);
					}
					// Limpiar el buffer y el campo de texto
					bufferedWriter.flush();
					textField.setText("");
				} catch (IOException e1) {
					e1.printStackTrace();
				}
			}
		});
		botonAnadir.setBounds(80, 125, 89, 23);
		frame.getContentPane().add(botonAnadir);

		// JScrollPane para permitir desplazarse por el JTextArea
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(243, 105, 130, 127);
		frame.getContentPane().add(scrollPane);

		// JTextArea para mostrar y visualizar los textos guardados
		textArea = new JTextArea();
		scrollPane.setViewportView(textArea);

		// Botón para visualizar los textos guardados en el archivo
		JButton botonVisualizar = new JButton("VISUALIZAR");
		botonVisualizar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					// Leer líneas del archivo y mostrarlas en el JTextArea
					String line = bufferedReader.readLine();
					while (line != null) {
						textArea.append(line + "\n");
						line = bufferedReader.readLine();
					}
				} catch (IOException e1) {
					e1.printStackTrace();
				}
			}
		});
		botonVisualizar.setBounds(243, 33, 130, 23);
		frame.getContentPane().add(botonVisualizar);

		// Botón para borrar los textos guardados en el archivo y limpiar el JTextArea
		JButton botonBorrar = new JButton("BORRAR");
		botonBorrar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				// Limpiar el JTextArea
				textArea.setText("");
				// Borrar el contenido del archivo
				FileWriter fileWriter;
				try {
					fileWriter = new FileWriter(file, false); // false indica que no se sobrescribirá el archivo
					fileWriter.write("");
					fileWriter.close();
				} catch (IOException e1) {
					e1.printStackTrace();
				}
			}
		});
		botonBorrar.setBackground(new Color(255, 0, 0));
		botonBorrar.setBounds(267, 65, 89, 23);
		frame.getContentPane().add(botonBorrar);
	}
}
