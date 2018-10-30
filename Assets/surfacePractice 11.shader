Shader "surfaceShaderPractice10" {
    Properties{
        _DiffuseColor("Diffuse Color", Color) = (1.0, 1.0, 1.0)
    }
    SubShader{
        Tags{"RenderType" = "Opaque"}
        
        CGPROGRAM
            // カスタムライティングを施すための関数
            // この中にライティング処理を記述する
            #pragma surface surf Original
            //関数の名前は、Lighting<名前>となる。#pragmaで｢Original｣と定義したので、ここではLightingOriginalとなる
            // SurfaceOutput s : サーフェスシェーダーの出力
            // lightDir : オブジェクトから光源への方向ベクトル
            // atten : ライトの減衰（影などの表現に必要）
            half4 LightingOriginal(SurfaceOutput s, half3 lightDir, half atten){
                // オブジェクトの法線ベクトル（オブジェクトの面の向き）と光源の方向をdot(内積)を求めることにより
                // 光源の方向を向いている面ほど明るくなる計算をしている（計算結果が0以下の際は、0に丸めている）
                half diff = dot(s.Normal, lightDir);
                if (diff < 0) diff = 0;
                half4 c;
                // サーフェスシェーダーからの出力された色に対して、
                // _LightColor0.rgb(ライトの色)とdiff（先程計算した光源の影響による明るさ）とatten(減衰)*2 を掛け算している
                // アルファチェンネルには、そのままの値を代入している
                c.rgb = s.Albedo * _LightColor0.rgb * (diff * atten * 2);
                c.a = s.Alpha;
                // ライティングを施した結果を返している
                return c;
            }
            struct Input{
                float4 color:COLOR;
            };
            float3 _DiffuseColor;
            
            void surf(Input IN, inout SurfaceOutput o){
                o.Albedo = _DiffuseColor;
            } 
        ENDCG
    }
    FallBack "Diffuse"
} 