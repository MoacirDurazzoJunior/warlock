// Upgrade NOTE: commented out 'float4 unity_DynamicLightmapST', a built-in variable
// Upgrade NOTE: commented out 'float4 unity_LightmapST', a built-in variable

// Shader created with Shader Forge v1.04 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.04;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,limd:0,uamb:True,mssp:True,lmpd:False,lprd:False,rprd:False,enco:False,frtr:True,vitr:True,dbil:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:2,bsrc:0,bdst:0,culm:2,dpts:2,wrdp:False,dith:2,ufog:False,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:1,x:37626,y:32712,varname:node_1,prsc:2|emission-2392-OUT;n:type:ShaderForge.SFN_Multiply,id:890,x:37057,y:32726,varname:node_890,prsc:2|A-1876-RGB,B-1665-OUT;n:type:ShaderForge.SFN_Add,id:892,x:34684,y:33256,varname:node_892,prsc:2|A-1805-OUT,B-1771-OUT;n:type:ShaderForge.SFN_Multiply,id:895,x:35905,y:32829,varname:node_895,prsc:2|A-1316-R,B-892-OUT;n:type:ShaderForge.SFN_Tex2d,id:896,x:34334,y:32174,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_2144,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2539-OUT;n:type:ShaderForge.SFN_Add,id:974,x:36284,y:32685,varname:node_974,prsc:2|A-1898-OUT,B-1771-OUT;n:type:ShaderForge.SFN_Tex2d,id:1316,x:35631,y:32726,ptovrint:False,ptlb:Gradient_Texture_Decay,ptin:_Gradient_Texture_Decay,varname:node_185,prsc:2,tex:1afc2415b297bab478597580754713c6,ntxv:0,isnm:False|UVIN-1319-OUT;n:type:ShaderForge.SFN_Append,id:1319,x:35438,y:32726,varname:node_1319,prsc:2|A-1948-OUT,B-1359-OUT;n:type:ShaderForge.SFN_TexCoord,id:1336,x:34249,y:32447,varname:node_1336,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:1340,x:34422,y:32527,varname:node_1340,prsc:2|A-1336-V,B-1342-OUT;n:type:ShaderForge.SFN_Vector1,id:1342,x:34249,y:32606,varname:node_1342,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:1359,x:34729,y:32623,varname:node_1359,prsc:2|A-1340-OUT,B-2056-OUT;n:type:ShaderForge.SFN_Add,id:1497,x:34729,y:32877,varname:node_1497,prsc:2|A-896-R,B-1805-OUT;n:type:ShaderForge.SFN_TexCoord,id:1618,x:34024,y:33456,varname:node_1618,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:1620,x:34198,y:33456,ptovrint:False,ptlb:Gradient_Edge_Fake,ptin:_Gradient_Edge_Fake,varname:node_4368,prsc:2,tex:90dd325f1880d4c4dbf7511cdec5fd07,ntxv:0,isnm:False|UVIN-1618-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:1652,x:36701,y:32948,varname:node_1652,prsc:2,uv:0;n:type:ShaderForge.SFN_Append,id:1654,x:36897,y:32888,varname:node_1654,prsc:2|A-1665-OUT,B-1652-V;n:type:ShaderForge.SFN_Tex2d,id:1656,x:37063,y:32888,ptovrint:False,ptlb:Gradient_Color,ptin:_Gradient_Color,varname:node_6487,prsc:2,tex:d6b46348e3be7e84c83d9734a828e81a,ntxv:0,isnm:False|UVIN-1654-OUT;n:type:ShaderForge.SFN_Clamp,id:1665,x:36687,y:32782,varname:node_1665,prsc:2|IN-2108-OUT,MIN-1667-OUT,MAX-1666-OUT;n:type:ShaderForge.SFN_Vector1,id:1666,x:36494,y:32864,varname:node_1666,prsc:2,v1:0.95;n:type:ShaderForge.SFN_Vector1,id:1667,x:36494,y:32815,varname:node_1667,prsc:2,v1:0.05;n:type:ShaderForge.SFN_SwitchProperty,id:1771,x:34389,y:33456,ptovrint:False,ptlb:Edge_Fake,ptin:_Edge_Fake,varname:node_6025,prsc:2,on:True|A-1772-OUT,B-1620-R;n:type:ShaderForge.SFN_Vector1,id:1772,x:34198,y:33311,varname:node_1772,prsc:2,v1:0;n:type:ShaderForge.SFN_SwitchProperty,id:1805,x:34407,y:33090,ptovrint:False,ptlb:Mask,ptin:_Mask,varname:node_1516,prsc:2,on:True|A-1772-OUT,B-2081-R;n:type:ShaderForge.SFN_SwitchProperty,id:1858,x:37231,y:32811,ptovrint:False,ptlb:Gradient_Or_Solid_Color,ptin:_Gradient_Or_Solid_Color,varname:node_1156,prsc:2,on:True|A-890-OUT,B-1656-RGB;n:type:ShaderForge.SFN_Color,id:1876,x:36687,y:32636,ptovrint:False,ptlb:Solid_Color,ptin:_Solid_Color,varname:node_9863,prsc:2,glob:False,c1:0.1764706,c2:0.5229208,c3:1,c4:1;n:type:ShaderForge.SFN_SwitchProperty,id:1898,x:36090,y:32810,ptovrint:False,ptlb:Make_Same_As_Mask,ptin:_Make_Same_As_Mask,varname:node_6989,prsc:2,on:True|A-1316-R,B-895-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:1948,x:35246,y:32795,ptovrint:False,ptlb:Soft_Texture,ptin:_Soft_Texture,varname:node_5303,prsc:2,on:False|A-2339-OUT,B-896-R;n:type:ShaderForge.SFN_Slider,id:2056,x:34255,y:32764,ptovrint:False,ptlb:Decay,ptin:_Decay,varname:node_6051,prsc:2,min:0.05,cur:0.3,max:0.95;n:type:ShaderForge.SFN_Tex2d,id:2081,x:34198,y:33090,ptovrint:False,ptlb:Mask_Texture,ptin:_Mask_Texture,varname:node_4203,prsc:2,tex:595df77cdf0a1b64a9da15f136642fb4,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2108,x:36494,y:32685,varname:node_2108,prsc:2|A-974-OUT,B-2109-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2109,x:36284,y:32844,ptovrint:False,ptlb:Intensity,ptin:_Intensity,varname:node_6005,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Subtract,id:2339,x:34919,y:32797,varname:node_2339,prsc:2|A-2056-OUT,B-1497-OUT;n:type:ShaderForge.SFN_Multiply,id:2392,x:37432,y:32811,varname:node_2392,prsc:2|A-1858-OUT,B-2393-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2393,x:37242,y:32960,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_9830,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Time,id:2529,x:33504,y:32279,varname:node_2529,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2531,x:33724,y:32247,varname:node_2531,prsc:2|A-2529-T,B-2595-OUT;n:type:ShaderForge.SFN_Time,id:2533,x:33515,y:32056,varname:node_2533,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2535,x:33724,y:32128,varname:node_2535,prsc:2|A-2533-T,B-2597-OUT;n:type:ShaderForge.SFN_TexCoord,id:2537,x:33724,y:31977,varname:node_2537,prsc:2,uv:0;n:type:ShaderForge.SFN_Append,id:2539,x:34140,y:32174,varname:node_2539,prsc:2|A-2582-OUT,B-2592-OUT;n:type:ShaderForge.SFN_Add,id:2582,x:33932,y:32116,varname:node_2582,prsc:2|A-2537-U,B-2535-OUT;n:type:ShaderForge.SFN_Add,id:2592,x:33932,y:32247,varname:node_2592,prsc:2|A-2537-V,B-2531-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2595,x:33504,y:32426,ptovrint:False,ptlb:Pan_SpeedY,ptin:_Pan_SpeedY,varname:node_3009,prsc:2,glob:False,v1:0.1;n:type:ShaderForge.SFN_ValueProperty,id:2597,x:33515,y:32208,ptovrint:False,ptlb:Pan_SpeedX,ptin:_Pan_SpeedX,varname:node_7768,prsc:2,glob:False,v1:0;proporder:2393-2109-1858-1656-1876-896-1316-2056-1805-1898-2081-1771-1620-1948-2595-2597;pass:END;sub:END;*/

Shader "ZFS Shaders/ZFS_Flat_Free_PanXY" {
    Properties {
        _Brightness ("Brightness", Float ) = 1
        _Intensity ("Intensity", Float ) = 1
        [MaterialToggle] _Gradient_Or_Solid_Color ("Gradient_Or_Solid_Color", Float ) = 0.007843138
        _Gradient_Color ("Gradient_Color", 2D) = "white" {}
        _Solid_Color ("Solid_Color", Color) = (0.1764706,0.5229208,1,1)
        _Texture ("Texture", 2D) = "white" {}
        _Gradient_Texture_Decay ("Gradient_Texture_Decay", 2D) = "white" {}
        _Decay ("Decay", Range(0.05, 0.95)) = 0.3
        [MaterialToggle] _Mask ("Mask", Float ) = 1
        [MaterialToggle] _Make_Same_As_Mask ("Make_Same_As_Mask", Float ) = 0
        _Mask_Texture ("Mask_Texture", 2D) = "white" {}
        [MaterialToggle] _Edge_Fake ("Edge_Fake", Float ) = 0
        _Gradient_Edge_Fake ("Gradient_Edge_Fake", 2D) = "white" {}
        [MaterialToggle] _Soft_Texture ("Soft_Texture", Float ) = -1.398039
        _Pan_SpeedY ("Pan_SpeedY", Float ) = 0.1
        _Pan_SpeedX ("Pan_SpeedX", Float ) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers xbox360 ps3 flash d3d11_9x 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            // float4 unity_LightmapST;
            #ifdef DYNAMICLIGHTMAP_ON
                // float4 unity_DynamicLightmapST;
            #endif
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform sampler2D _Gradient_Texture_Decay; uniform float4 _Gradient_Texture_Decay_ST;
            uniform sampler2D _Gradient_Edge_Fake; uniform float4 _Gradient_Edge_Fake_ST;
            uniform sampler2D _Gradient_Color; uniform float4 _Gradient_Color_ST;
            uniform fixed _Edge_Fake;
            uniform fixed _Mask;
            uniform fixed _Gradient_Or_Solid_Color;
            uniform float4 _Solid_Color;
            uniform fixed _Make_Same_As_Mask;
            uniform fixed _Soft_Texture;
            uniform float _Decay;
            uniform sampler2D _Mask_Texture; uniform float4 _Mask_Texture_ST;
            uniform float _Intensity;
            uniform float _Brightness;
            uniform float _Pan_SpeedY;
            uniform float _Pan_SpeedX;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                #ifndef LIGHTMAP_OFF
                    float4 uvLM : TEXCOORD1;
                #else
                    float3 shLight : TEXCOORD1;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
/////// Vectors:
////// Lighting:
////// Emissive:
                float4 node_2533 = _Time + _TimeEditor;
                float4 node_2529 = _Time + _TimeEditor;
                float2 node_2539 = float2((i.uv0.r+(node_2533.g*_Pan_SpeedX)),(i.uv0.g+(node_2529.g*_Pan_SpeedY)));
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(node_2539, _Texture));
                float node_1772 = 0.0;
                float4 _Mask_Texture_var = tex2D(_Mask_Texture,TRANSFORM_TEX(i.uv0, _Mask_Texture));
                float _Mask_var = lerp( node_1772, _Mask_Texture_var.r, _Mask );
                float2 node_1319 = float2(lerp( (_Decay-(_Texture_var.r+_Mask_var)), _Texture_var.r, _Soft_Texture ),((i.uv0.g*0.0)+_Decay));
                float4 _Gradient_Texture_Decay_var = tex2D(_Gradient_Texture_Decay,TRANSFORM_TEX(node_1319, _Gradient_Texture_Decay));
                float4 _Gradient_Edge_Fake_var = tex2D(_Gradient_Edge_Fake,TRANSFORM_TEX(i.uv0, _Gradient_Edge_Fake));
                float _Edge_Fake_var = lerp( node_1772, _Gradient_Edge_Fake_var.r, _Edge_Fake );
                float node_1665 = clamp(((lerp( _Gradient_Texture_Decay_var.r, (_Gradient_Texture_Decay_var.r*(_Mask_var+_Edge_Fake_var)), _Make_Same_As_Mask )+_Edge_Fake_var)*_Intensity),0.05,0.95);
                float2 node_1654 = float2(node_1665,i.uv0.g);
                float4 _Gradient_Color_var = tex2D(_Gradient_Color,TRANSFORM_TEX(node_1654, _Gradient_Color));
                float3 emissive = (lerp( (_Solid_Color.rgb*node_1665), _Gradient_Color_var.rgb, _Gradient_Or_Solid_Color )*_Brightness);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
