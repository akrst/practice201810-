Shader"surfaceShaderPractice6"{
    Properties{
        _DiffuseColor("Diffuse Color", Color) = (1.0, 1.0, 1.0)
        _EmissionColor("Emission Color", Color) = (0.0, 0.0, 0.0)
    }
    SubShader{
        Tags {"RenderType" = "Opaque"}
        
        CGPROGRAM
            #pragma surface surf Lambert
            struct Input {
                float2 color: COLOR;
            };
            
            float4 _DiffuseColor;
            float4 _EmissionColor;
            
            void surf(Input IN, inout SurfaceOutput o){
                o.Albedo = _DiffuseColor;
                // 0.Emissionに対して、Inspectorの設定を代入
                o.Emission = _EmissionColor;
            }
        ENDCG
    }
    FallBack "Diffuse"
}