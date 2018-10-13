Shader "Custom/surfacePractice5"{
    Properties{
        _Texture("MainTexture", 2D) = "white"{}
        _Bump("Bump", 2D) = "white"{}
    }
    
    SubShader{
        Tags{"RenderType" = "Opaque"}
        
        CGPROGRAM
        #pragma surface surf Lambert
        struct Input {
            float2 uv_Texture;
            float2 uv_Bump;
        };
        
        sampler2D _Texture;
        sampler2D _Bump;
        
        void surf(Input IN, inout SurfaceOutput o){
            o.Albedo = tex2D(_Texture, IN.uv_Texture).rgb;
            o.Normal = UnpackNormal(tex2D(_Bump, IN.uv_Bump));
        }
        ENDCG
    }
    FallBack "Diffuse"
}