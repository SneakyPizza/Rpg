Shader "Custom/LightShader" {
	Properties {
		_TempColor("My colour",Color) = (117,255,85) //green
		_MainTex ("Texture", 2D) = "white"{}
		
		_Center("Center",Vector) = (0,0,0,0)
		_Radius("Radius",Float) = 0.5
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		CGPROGRAM
		#pragma surface surf Lambert
		struct Input{
		float2 uv_MainTex;
		float3 worldPos;
		float4 color:COLOR;
		};
		
		sampler2D _MainTex;
		half4 _TempColor;
		
		float3 _Center;
		float _Radius;
		
		void surf (Input IN, inout SurfaceOutput o) {
          //o.Albedo = _TempColor;
          float d = distance(_Center, IN.worldPos);
          float dN = 1 - saturate(d / _Radius);
          
          if(dN > 0.25 && dN <0.3)
          	o.Albedo = _TempColor.rgb;
          	else
          	o.Albedo =  tex2D(_MainTex, IN.uv_MainTex).rgb;
      }
		ENDCG
	} 
	FallBack "Diffuse"
}
