Shader "Custom/Simple colored lighting" {
	Properties {
		//_MainTex ("Base (RGB)", 2D) = "white" {}
        _Color("Main Color", Color) = (1, 0.5, 0.5, 1)
	}
	SubShader {
        Pass {
            Material {
               Diffuse[_Color] 
            }
            Lighting On
        }
	} 
	FallBack "Diffuse"
}
