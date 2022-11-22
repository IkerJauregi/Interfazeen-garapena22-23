package com.example.ierabiltzaileaxml;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;

public class Bigarrena extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //.Bigarrena jarri txarto badoa
        setContentView(R.layout.activity_main2);

        //Checkbox eta button bariableak sortzeko dira

        CheckBox cbEnglish = (CheckBox) findViewById(R.id.cbEnglish);
        Button btnBai = (Button)findViewById(R.id.btnBai);
        Button btnEz = (Button)findViewById(R.id.btnEz);
        cbEnglish.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                if (cbEnglish.isChecked())
                {
                    btnBai.setText(R.string.bai_en);
                    btnEz.setText(R.string.ez_en);
                }
                else
                {
                    btnBai.setText(R.string.bai_eu);
                    btnEz.setText(R.string.ez_eu);
                }
            }
        });
    }
}