package br.edu.fecap.nisoccercamp;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.SeekBar;
import android.widget.TextView;
import android.widget.Toast;




public class MainActivity extends AppCompatActivity {

    CheckBox checkFutsal, checkCampo, checkSociety, checkAreaDeLazer;

    EditText editTextBairro;
    private SeekBar seekBarValor;
    TextView txtValor;
    int ValorDaQuadra;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txtValor = findViewById(R.id.txtValor);

        seekBarValor = findViewById(R.id.seekBarValor);

        checkFutsal = findViewById(R.id.checkBoxFutsal);
        checkCampo = findViewById(R.id.checkBoxCampo);
        checkSociety = findViewById(R.id.checkBoxSociety);
        checkAreaDeLazer = findViewById(R.id.checkBoxLazer);

        seekBarValor.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean fromUser) {
                ValorDaQuadra = seekBarValor.getProgress() + 50;
                calcular();

            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });
    }
    public void calcular() {
        txtValor.setText("R$ " + ValorDaQuadra );
    }
    public void  limparCheckbox(View view){

        seekBarValor.setProgress(0);

        EditText editTextBairro = findViewById(R.id.editTextBairro);
        editTextBairro.setText("");

        if (checkAreaDeLazer.isChecked()){
            checkAreaDeLazer.setChecked(false);
        }
        if (checkCampo.isChecked()){
            checkCampo.setChecked(false);
        }
        if (checkFutsal.isChecked()){
            checkFutsal.setChecked(false);
        }
        if (checkSociety.isChecked()){
            checkSociety.setChecked(false);
        }
    }

    public void Buscar(View view){
        String texto = "";
        int quadras =0;
        if(checkCampo.isChecked()){
            texto+= "Campo\n";
            quadras+= 5;
        }
        if(checkAreaDeLazer.isChecked()){
            texto+= "Area de Lazer\n";
            quadras+= -2;
        }
        if(checkSociety.isChecked()){
            texto+= "Society\n";
            quadras+= 4;
        }
        if(checkFutsal.isChecked()){
            texto+= "Futsal\n";
            quadras+= 3;
        }
        if(quadras == -2){
            quadras = 5;
        }
        if(quadras == 10){
            quadras = 5;
        }


        AlertDialog.Builder dialog = new AlertDialog.Builder(this);

        dialog.setTitle("TEM CERTEZA DA SUA ESCOLHA?");
        dialog.setMessage(texto + "Quadras disponíveis: " + quadras);

        dialog.setCancelable(false);

        dialog.setIcon(android.R.drawable.dialog_holo_dark_frame);

        dialog.setPositiveButton("Sim", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                Toast.makeText(
                        getApplicationContext(),
                        "Buscando as localizações...",
                        Toast.LENGTH_LONG
                ).show();
            }
        });

        dialog.setNegativeButton("Não", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                Toast.makeText(
                        getApplicationContext(),
                        "Aguardando sua escolha...",
                        Toast.LENGTH_LONG
                ).show();
            }
        });

        //Criar e Exibir AlertDialog
        dialog.create();
        dialog.show();
    }
}


