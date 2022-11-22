package com.example.ierabiltzaileaxml;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private TextView txtTestua;
    private Button btnAgurra;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txtTestua = (TextView)findViewById(R.id.txtTestua);
        btnAgurra = (Button)findViewById(R.id.btnAgurra);
        btnAgurra.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v){
                txtTestua.setText("Kaixo Mundua!!!");}
        });
    }
}