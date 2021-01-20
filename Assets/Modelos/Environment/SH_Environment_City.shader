// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:False,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:False,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:32720,y:32712,varname:node_2865,prsc:2|diff-6021-OUT,spec-358-OUT,gloss-1813-OUT,normal-1922-OUT;n:type:ShaderForge.SFN_Tex2d,id:7736,x:30960,y:33114,ptovrint:True,ptlb:Mix Channels,ptin:_Mix_Channels,varname:_Mix_Channels,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:5964,x:32028,y:32978,ptovrint:True,ptlb:Normal Map,ptin:_Normal_Map,varname:_Normal_Map,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Slider,id:358,x:32250,y:32745,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:_Metallic,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:1813,x:32250,y:32849,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Gloss,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2,max:1;n:type:ShaderForge.SFN_Tex2d,id:3622,x:31440,y:32286,ptovrint:False,ptlb:Albedo01,ptin:_Albedo01,varname:_Albedo01,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:235,x:31440,y:32463,ptovrint:False,ptlb:Albedo02,ptin:_Albedo02,varname:_Albedo02,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3203,x:31440,y:32639,ptovrint:False,ptlb:Albedo03,ptin:_Albedo03,varname:node_3203,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:6049,x:31440,y:32810,ptovrint:False,ptlb:Albedo04,ptin:_Albedo04,varname:node_6049,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:1315,x:31400,y:33242,ptovrint:False,ptlb:Normal01,ptin:_Normal01,varname:node_1315,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:9939,x:31400,y:33444,ptovrint:False,ptlb:Normal02,ptin:_Normal02,varname:node_9939,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:3932,x:31400,y:33632,ptovrint:False,ptlb:Normal03,ptin:_Normal03,varname:node_3932,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:2162,x:31400,y:33823,ptovrint:False,ptlb:Normal04,ptin:_Normal04,varname:node_2162,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Lerp,id:2458,x:31686,y:32324,varname:node_2458,prsc:2|A-3622-RGB,B-235-RGB,T-7736-R;n:type:ShaderForge.SFN_Lerp,id:1587,x:31839,y:32491,varname:node_1587,prsc:2|A-2458-OUT,B-3203-RGB,T-7736-G;n:type:ShaderForge.SFN_Lerp,id:6021,x:31990,y:32643,varname:node_6021,prsc:2|A-1587-OUT,B-6049-RGB,T-7736-B;n:type:ShaderForge.SFN_Lerp,id:97,x:31605,y:33326,varname:node_97,prsc:2|A-1315-RGB,B-9939-RGB,T-7736-R;n:type:ShaderForge.SFN_Lerp,id:5144,x:31756,y:33484,varname:node_5144,prsc:2|A-97-OUT,B-3932-RGB,T-7736-G;n:type:ShaderForge.SFN_Lerp,id:5821,x:31917,y:33714,varname:node_5821,prsc:2|A-5144-OUT,B-2162-RGB,T-7736-B;n:type:ShaderForge.SFN_Lerp,id:1922,x:32469,y:33071,varname:node_1922,prsc:2|A-6505-OUT,B-8008-OUT,T-5230-OUT;n:type:ShaderForge.SFN_Slider,id:5230,x:31888,y:33187,ptovrint:False,ptlb:NormalSt,ptin:_NormalSt,varname:node_5230,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Vector3,id:6505,x:32224,y:32939,varname:node_6505,prsc:2,v1:0.5,v2:0.5,v3:1;n:type:ShaderForge.SFN_Lerp,id:8008,x:32316,y:33268,varname:node_8008,prsc:2|A-5964-RGB,B-5821-OUT,T-4583-OUT;n:type:ShaderForge.SFN_Slider,id:4583,x:31845,y:33337,ptovrint:False,ptlb:NormalBigSmall,ptin:_NormalBigSmall,varname:node_4583,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;proporder:7736-3622-235-3203-6049-358-1813-5964-1315-9939-3932-2162-5230-4583;pass:END;sub:END;*/

Shader "Jorgito/SH_Environment_City" {
    Properties {
        _Mix_Channels ("Mix Channels", 2D) = "white" {}
        _Albedo01 ("Albedo01", 2D) = "white" {}
        _Albedo02 ("Albedo02", 2D) = "white" {}
        _Albedo03 ("Albedo03", 2D) = "white" {}
        _Albedo04 ("Albedo04", 2D) = "white" {}
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Gloss ("Gloss", Range(0, 1)) = 0.2
        _Normal_Map ("Normal Map", 2D) = "bump" {}
        _Normal01 ("Normal01", 2D) = "bump" {}
        _Normal02 ("Normal02", 2D) = "bump" {}
        _Normal03 ("Normal03", 2D) = "bump" {}
        _Normal04 ("Normal04", 2D) = "bump" {}
        _NormalSt ("NormalSt", Range(0, 1)) = 1
        _NormalBigSmall ("NormalBigSmall", Range(0, 1)) = 0.5
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Mix_Channels; uniform float4 _Mix_Channels_ST;
            uniform sampler2D _Normal_Map; uniform float4 _Normal_Map_ST;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform sampler2D _Albedo01; uniform float4 _Albedo01_ST;
            uniform sampler2D _Albedo02; uniform float4 _Albedo02_ST;
            uniform sampler2D _Albedo03; uniform float4 _Albedo03_ST;
            uniform sampler2D _Albedo04; uniform float4 _Albedo04_ST;
            uniform sampler2D _Normal01; uniform float4 _Normal01_ST;
            uniform sampler2D _Normal02; uniform float4 _Normal02_ST;
            uniform sampler2D _Normal03; uniform float4 _Normal03_ST;
            uniform sampler2D _Normal04; uniform float4 _Normal04_ST;
            uniform float _NormalSt;
            uniform float _NormalBigSmall;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD10;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_Map_var = UnpackNormal(tex2D(_Normal_Map,TRANSFORM_TEX(i.uv0, _Normal_Map)));
                float3 _Normal01_var = UnpackNormal(tex2D(_Normal01,TRANSFORM_TEX(i.uv0, _Normal01)));
                float3 _Normal02_var = UnpackNormal(tex2D(_Normal02,TRANSFORM_TEX(i.uv0, _Normal02)));
                float4 _Mix_Channels_var = tex2D(_Mix_Channels,TRANSFORM_TEX(i.uv0, _Mix_Channels));
                float3 _Normal03_var = UnpackNormal(tex2D(_Normal03,TRANSFORM_TEX(i.uv0, _Normal03)));
                float3 _Normal04_var = UnpackNormal(tex2D(_Normal04,TRANSFORM_TEX(i.uv0, _Normal04)));
                float3 node_5821 = lerp(lerp(lerp(_Normal01_var.rgb,_Normal02_var.rgb,_Mix_Channels_var.r),_Normal03_var.rgb,_Mix_Channels_var.g),_Normal04_var.rgb,_Mix_Channels_var.b);
                float3 normalLocal = lerp(float3(0.5,0.5,1),lerp(_Normal_Map_var.rgb,node_5821,_NormalBigSmall),_NormalSt);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float perceptualRoughness = 1.0 - _Gloss;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = _Metallic;
                float specularMonochrome;
                float4 _Albedo01_var = tex2D(_Albedo01,TRANSFORM_TEX(i.uv0, _Albedo01));
                float4 _Albedo02_var = tex2D(_Albedo02,TRANSFORM_TEX(i.uv0, _Albedo02));
                float4 _Albedo03_var = tex2D(_Albedo03,TRANSFORM_TEX(i.uv0, _Albedo03));
                float4 _Albedo04_var = tex2D(_Albedo04,TRANSFORM_TEX(i.uv0, _Albedo04));
                float3 diffuseColor = lerp(lerp(lerp(_Albedo01_var.rgb,_Albedo02_var.rgb,_Mix_Channels_var.r),_Albedo03_var.rgb,_Mix_Channels_var.g),_Albedo04_var.rgb,_Mix_Channels_var.b); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Mix_Channels; uniform float4 _Mix_Channels_ST;
            uniform sampler2D _Normal_Map; uniform float4 _Normal_Map_ST;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform sampler2D _Albedo01; uniform float4 _Albedo01_ST;
            uniform sampler2D _Albedo02; uniform float4 _Albedo02_ST;
            uniform sampler2D _Albedo03; uniform float4 _Albedo03_ST;
            uniform sampler2D _Albedo04; uniform float4 _Albedo04_ST;
            uniform sampler2D _Normal01; uniform float4 _Normal01_ST;
            uniform sampler2D _Normal02; uniform float4 _Normal02_ST;
            uniform sampler2D _Normal03; uniform float4 _Normal03_ST;
            uniform sampler2D _Normal04; uniform float4 _Normal04_ST;
            uniform float _NormalSt;
            uniform float _NormalBigSmall;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_Map_var = UnpackNormal(tex2D(_Normal_Map,TRANSFORM_TEX(i.uv0, _Normal_Map)));
                float3 _Normal01_var = UnpackNormal(tex2D(_Normal01,TRANSFORM_TEX(i.uv0, _Normal01)));
                float3 _Normal02_var = UnpackNormal(tex2D(_Normal02,TRANSFORM_TEX(i.uv0, _Normal02)));
                float4 _Mix_Channels_var = tex2D(_Mix_Channels,TRANSFORM_TEX(i.uv0, _Mix_Channels));
                float3 _Normal03_var = UnpackNormal(tex2D(_Normal03,TRANSFORM_TEX(i.uv0, _Normal03)));
                float3 _Normal04_var = UnpackNormal(tex2D(_Normal04,TRANSFORM_TEX(i.uv0, _Normal04)));
                float3 node_5821 = lerp(lerp(lerp(_Normal01_var.rgb,_Normal02_var.rgb,_Mix_Channels_var.r),_Normal03_var.rgb,_Mix_Channels_var.g),_Normal04_var.rgb,_Mix_Channels_var.b);
                float3 normalLocal = lerp(float3(0.5,0.5,1),lerp(_Normal_Map_var.rgb,node_5821,_NormalBigSmall),_NormalSt);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float perceptualRoughness = 1.0 - _Gloss;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = _Metallic;
                float specularMonochrome;
                float4 _Albedo01_var = tex2D(_Albedo01,TRANSFORM_TEX(i.uv0, _Albedo01));
                float4 _Albedo02_var = tex2D(_Albedo02,TRANSFORM_TEX(i.uv0, _Albedo02));
                float4 _Albedo03_var = tex2D(_Albedo03,TRANSFORM_TEX(i.uv0, _Albedo03));
                float4 _Albedo04_var = tex2D(_Albedo04,TRANSFORM_TEX(i.uv0, _Albedo04));
                float3 diffuseColor = lerp(lerp(lerp(_Albedo01_var.rgb,_Albedo02_var.rgb,_Mix_Channels_var.r),_Albedo03_var.rgb,_Mix_Channels_var.g),_Albedo04_var.rgb,_Mix_Channels_var.b); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Mix_Channels; uniform float4 _Mix_Channels_ST;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform sampler2D _Albedo01; uniform float4 _Albedo01_ST;
            uniform sampler2D _Albedo02; uniform float4 _Albedo02_ST;
            uniform sampler2D _Albedo03; uniform float4 _Albedo03_ST;
            uniform sampler2D _Albedo04; uniform float4 _Albedo04_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = 0;
                
                float4 _Albedo01_var = tex2D(_Albedo01,TRANSFORM_TEX(i.uv0, _Albedo01));
                float4 _Albedo02_var = tex2D(_Albedo02,TRANSFORM_TEX(i.uv0, _Albedo02));
                float4 _Mix_Channels_var = tex2D(_Mix_Channels,TRANSFORM_TEX(i.uv0, _Mix_Channels));
                float4 _Albedo03_var = tex2D(_Albedo03,TRANSFORM_TEX(i.uv0, _Albedo03));
                float4 _Albedo04_var = tex2D(_Albedo04,TRANSFORM_TEX(i.uv0, _Albedo04));
                float3 diffColor = lerp(lerp(lerp(_Albedo01_var.rgb,_Albedo02_var.rgb,_Mix_Channels_var.r),_Albedo03_var.rgb,_Mix_Channels_var.g),_Albedo04_var.rgb,_Mix_Channels_var.b);
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, _Metallic, specColor, specularMonochrome );
                float roughness = 1.0 - _Gloss;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
