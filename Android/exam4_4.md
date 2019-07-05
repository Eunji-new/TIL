
이벤트 리스너에서

버튼은 setOnClickListener만

체크박스는 setOnCheckChangeListner만

Radiobutton은 둘다 되는 것 같아.




# 안드로이드 버전 선택  xml

<?xml version="1.0" encoding="utf-8"?>
<ScrollView xmlns:android="http://schemas.android.com/apk/res/android"
    xmlns:app="http://schemas.android.com/apk/res-auto"
    xmlns:tools="http://schemas.android.com/tools"
    android:layout_width="match_parent"
    android:layout_height="match_parent">


<LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
    xmlns:app="http://schemas.android.com/apk/res-auto"
    xmlns:tools="http://schemas.android.com/tools"
    android:layout_width="match_parent"
    android:layout_height="match_parent"
    android:orientation="vertical"
    android:padding="40px"
    tools:context="com.cookandroid.exam4_4.MainActivity">


    <TextView
        android:id="@+id/choice"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:textSize="30dp"
        android:text="선택을 시작하겠습니까?" />

    <Switch
        android:id="@+id/switch1"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:textSize="20dp"
        android:text="시작함    " />
    <TextView
        android:id="@+id/and_like"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:textSize="20dp"
        android:text="좋아하는 안드로이드 버전은?"
        android:visibility="invisible"/>
    <RadioGroup
        android:id="@+id/and_group"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:visibility="invisible">
        <RadioButton
            android:id="@+id/lollipop"
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:text="롤리팝"/>
        <RadioButton
            android:id="@+id/macimellow"
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:text="마시멜로"/>
        <RadioButton
            android:id="@+id/nuga"
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:text="누가"/>
    </RadioGroup>

    <ImageView
        android:id="@+id/image_and"
        android:layout_width="500px"
        android:layout_height="300px"
        android:visibility="invisible"/>

    <Button
        android:id="@+id/fin"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:text="종료"/>

    <Button
        android:id="@+id/reset"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:text="처음으로"/>
<//LinearLayout>
<//ScrollView>


# Main.java

package com.cookandroid.exam4_4;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Switch;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    TextView text1, text2;
    Switch agree;
    RadioGroup rGroup1;
    RadioButton rlolli, rma, rnuga;
    Button finish, reset;
    ImageView img;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setTitle("최애 안드로이드 선택하기");

        text1 = (TextView) findViewById(R.id.choice);
        agree = (Switch) findViewById(R.id.switch1);

        text2 = (TextView) findViewById(R.id.and_like);
        rGroup1 = (RadioGroup) findViewById((R.id.and_group));
        rlolli = (RadioButton) findViewById(R.id.lollipop);
        rma = (RadioButton) findViewById(R.id.macimellow);
        rnuga = (RadioButton) findViewById(R.id.nuga);

        finish = (Button) findViewById(R.id.fin);
        reset = (Button) findViewById(R.id.reset);
        img = (ImageView) findViewById(R.id.image_and);

        agree.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b) {

                if(agree.isChecked() == true)
                {
                    text2.setVisibility(View.VISIBLE);
                    rGroup1.setVisibility(View.VISIBLE);
                    img.setVisibility(View.VISIBLE);

                }
                else
                {
                    text2.setVisibility(View.INVISIBLE);
                    rGroup1.setVisibility(View.INVISIBLE);
                    img.setVisibility(View.INVISIBLE);
                }
            }
        });

        rlolli.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                img.setImageResource(R.drawable.lollipop);
            }
        });

        rma.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b) {
                img.setImageResource(R.drawable.mashi);
            }
        });

        rnuga.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                img.setImageResource(R.drawable.nuga);
            }
        });

        finish.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        reset.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                text2.setVisibility(View.INVISIBLE);
                rGroup1.setVisibility(View.INVISIBLE);
                img.setVisibility(View.INVISIBLE);
            }
        });

    }


}

![image](https://user-images.githubusercontent.com/28985207/60668986-2d1bc600-9ea8-11e9-98a8-76c28d383245.png)
