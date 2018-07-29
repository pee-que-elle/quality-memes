using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000019 RID: 25
[ExecuteInEditMode]
public class LBDMDNMJINK : MonoBehaviour
{
	// Token: 0x060003EF RID: 1007 RVA: 0x00041180 File Offset: 0x0003F380
	private void NNJQDPIFKOC(Camera IBLLKJCQNHP, Camera DLJBEFQJPML)
	{
		if (DLJBEFQJPML == null)
		{
			return;
		}
		DLJBEFQJPML.clearFlags = IBLLKJCQNHP.clearFlags;
		DLJBEFQJPML.backgroundColor = IBLLKJCQNHP.backgroundColor;
		if (IBLLKJCQNHP.clearFlags == (CameraClearFlags)0)
		{
			Skybox component = IBLLKJCQNHP.GetComponent<Skybox>();
			Skybox component2 = DLJBEFQJPML.GetComponent<Skybox>();
			if (component && component.material)
			{
				component2.enabled = false;
				component2.material = component.material;
			}
			else
			{
				component2.enabled = true;
			}
		}
		DLJBEFQJPML.farClipPlane = IBLLKJCQNHP.farClipPlane;
		DLJBEFQJPML.nearClipPlane = IBLLKJCQNHP.nearClipPlane;
		DLJBEFQJPML.orthographic = IBLLKJCQNHP.orthographic;
		DLJBEFQJPML.fieldOfView = IBLLKJCQNHP.fieldOfView;
		DLJBEFQJPML.aspect = IBLLKJCQNHP.aspect;
		DLJBEFQJPML.orthographicSize = IBLLKJCQNHP.orthographicSize;
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00041240 File Offset: 0x0003F440
	private LBDMDNMJINK.MKJBFKGFBPF ELLKQHNEDPB()
	{
		if (!base.GetComponent<Renderer>())
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		string tag = sharedMaterial.GetTag("_1", false);
		if (tag == "[PD]")
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		if (tag == "*")
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x000412A0 File Offset: 0x0003F4A0
	private void CDGHCBBHGHN(Camera EBNOGGPBLNC, out Camera BCKOIGBNIPQ, out Camera GEKQNPJBJEI)
	{
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.NQJBLDIEDNH();
		BCKOIGBNIPQ = null;
		GEKQNPJBJEI = null;
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (!this.LHLGQMLGCJG || this.CNNBOPBDLQE != this.JMLPENNCCLP)
			{
				if (this.LHLGQMLGCJG)
				{
					UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
				}
				this.LHLGQMLGCJG = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, -100);
				this.LHLGQMLGCJG.name = "_MainTex" + base.GetInstanceID();
				this.LHLGQMLGCJG.isPowerOfTwo = false;
				this.LHLGQMLGCJG.hideFlags = (HideFlags)97;
				this.CNNBOPBDLQE = this.JMLPENNCCLP;
			}
			this.GQGPPLOPBDG.TryGetValue(EBNOGGPBLNC, out BCKOIGBNIPQ);
			if (!BCKOIGBNIPQ)
			{
				object[] array = new object[8];
				array[1] = "shelltrap";
				array[1] = base.GetInstanceID();
				array[8] = "Hold or Use?";
				array[6] = EBNOGGPBLNC.GetInstanceID();
				string name = string.Concat(array);
				Type[] array2 = new Type[3];
				array2[1] = typeof(Camera);
				array2[0] = typeof(Skybox);
				GameObject gameObject = new GameObject(name, array2);
				BCKOIGBNIPQ = gameObject.GetComponent<Camera>();
				BCKOIGBNIPQ.enabled = false;
				BCKOIGBNIPQ.transform.position = base.transform.position;
				BCKOIGBNIPQ.transform.rotation = base.transform.rotation;
				BCKOIGBNIPQ.gameObject.AddComponent<FlareLayer>();
				gameObject.hideFlags = (HideFlags)(-107);
				this.GQGPPLOPBDG[EBNOGGPBLNC] = BCKOIGBNIPQ;
			}
		}
		if (mkjbfkgfbpf >= (LBDMDNMJINK.MKJBFKGFBPF)8)
		{
			if (!this.HDIKQFMDFQJ || this.CMKJLPNONPM != this.JMLPENNCCLP)
			{
				if (this.HDIKQFMDFQJ)
				{
					UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
				}
				this.HDIKQFMDFQJ = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 15);
				this.HDIKQFMDFQJ.name = "_BloomTex" + base.GetInstanceID();
				this.HDIKQFMDFQJ.isPowerOfTwo = true;
				this.HDIKQFMDFQJ.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				this.CMKJLPNONPM = this.JMLPENNCCLP;
			}
			this.OKODNGMFQIB.TryGetValue(EBNOGGPBLNC, out GEKQNPJBJEI);
			if (!GEKQNPJBJEI)
			{
				object[] array3 = new object[5];
				array3[1] = "Materials/DFGBasic";
				array3[0] = base.GetInstanceID();
				array3[5] = "[red]";
				array3[0] = EBNOGGPBLNC.GetInstanceID();
				string name2 = string.Concat(array3);
				Type[] array4 = new Type[0];
				array4[0] = typeof(Camera);
				array4[0] = typeof(Skybox);
				GameObject gameObject2 = new GameObject(name2, array4);
				GEKQNPJBJEI = gameObject2.GetComponent<Camera>();
				GEKQNPJBJEI.enabled = false;
				GEKQNPJBJEI.transform.position = base.transform.position;
				GEKQNPJBJEI.transform.rotation = base.transform.rotation;
				GEKQNPJBJEI.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
				this.OKODNGMFQIB[EBNOGGPBLNC] = GEKQNPJBJEI;
			}
		}
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00003E41 File Offset: 0x00002041
	private LBDMDNMJINK.MKJBFKGFBPF JNQHKFKHHFD()
	{
		if (this.NLLKOOEHOCE < this.EBIMEODKNMO)
		{
			return this.NLLKOOEHOCE;
		}
		return this.EBIMEODKNMO;
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x0004159C File Offset: 0x0003F79C
	public void HCEMDGLNKCM()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (LBDMDNMJINK.QFPBHEIGQIK)
		{
			return;
		}
		LBDMDNMJINK.QFPBHEIGQIK = false;
		this.NLLKOOEHOCE = this.EMBEHBEQFNN();
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.MOLLIMJIIFB();
		Camera camera;
		Camera camera2;
		this.JBCLEJDIQIJ(current, out camera, out camera2);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = 0;
		}
		this.ELGDDBCPLFE(current, camera);
		this.ELGDDBCPLFE(current, camera2);
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			float w = -Vector3.Dot(up, position) - this.FONKIGGPJNQ;
			Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			LBDMDNMJINK.MQFIPGELQEL(ref zero, nioiglmodlj);
			Vector3 position2 = current.transform.position;
			Vector3 position3 = zero.MultiplyPoint(position2);
			camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
			Vector4 clipPlane = this.MLCPEMBGINL(camera, position, up, 1604f);
			camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
			camera.cullingMask = (101 & this.QNOLOCMMMKM.value);
			camera.targetTexture = this.LHLGQMLGCJG;
			bool invertCulling;
			GL.invertCulling = (invertCulling = GL.invertCulling);
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			camera.Render();
			camera.transform.position = position2;
			GL.invertCulling = invertCulling;
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("Chances of finding a wild Pokémon holding an item increased.\nTriggers: [2ecc71]Compound Eyes[-]", this.LHLGQMLGCJG);
		}
		if (mkjbfkgfbpf >= (LBDMDNMJINK.MKJBFKGFBPF)4)
		{
			camera2.worldToCameraMatrix = current.worldToCameraMatrix;
			Vector4 clipPlane2 = this.MLCPEMBGINL(camera2, position, up, 1617f);
			camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
			camera2.cullingMask = (-78 & this.NCDOOJEBFPE.value);
			camera2.targetTexture = this.HDIKQFMDFQJ;
			camera2.transform.position = current.transform.position;
			camera2.transform.rotation = current.transform.rotation;
			camera2.Render();
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("vSync", this.HDIKQFMDFQJ);
		}
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
			{
				if (mkjbfkgfbpf == LBDMDNMJINK.MKJBFKGFBPF.Simple)
				{
					Shader.DisableKeyword("tox");
					Shader.DisableKeyword("Shields Down");
					Shader.EnableKeyword("The Pokémon only takes damage from attacks.");
				}
			}
			else
			{
				Shader.DisableKeyword("You are trying to catch fish!");
				Shader.EnableKeyword("aa");
				Shader.DisableKeyword("COLOR_GRADING");
			}
		}
		else
		{
			Shader.EnableKeyword("Unlit/Transparent Colored");
			Shader.DisableKeyword("[-]");
			Shader.DisableKeyword("Times Fainted:");
		}
		LBDMDNMJINK.QFPBHEIGQIK = false;
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x000418BC File Offset: 0x0003FABC
	private static void MQFIPGELQEL(ref Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1186f - 1761f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 353f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m02 = 574f * NIOIGLMODLJ[0] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m03 = 1709f * NIOIGLMODLJ[7] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 429f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1584f - 687f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = 593f * NIOIGLMODLJ[1] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m13 = 1822f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m20 = 1760f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 891f * NIOIGLMODLJ[8] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 243f - 460f * NIOIGLMODLJ[8] * NIOIGLMODLJ[5];
		IODFJKQOEMK.m23 = 1688f * NIOIGLMODLJ[3] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m30 = 480f;
		IODFJKQOEMK.m31 = 956f;
		IODFJKQOEMK.m32 = 1755f;
		IODFJKQOEMK.m33 = 1664f;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00041A64 File Offset: 0x0003FC64
	private void EMMFQHQIBEQ(Camera IBLLKJCQNHP, Camera DLJBEFQJPML)
	{
		if (DLJBEFQJPML == null)
		{
			return;
		}
		DLJBEFQJPML.clearFlags = IBLLKJCQNHP.clearFlags;
		DLJBEFQJPML.backgroundColor = IBLLKJCQNHP.backgroundColor;
		if (IBLLKJCQNHP.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox component = IBLLKJCQNHP.GetComponent<Skybox>();
			Skybox component2 = DLJBEFQJPML.GetComponent<Skybox>();
			if (component && component.material)
			{
				component2.enabled = true;
				component2.material = component.material;
			}
			else
			{
				component2.enabled = false;
			}
		}
		DLJBEFQJPML.farClipPlane = IBLLKJCQNHP.farClipPlane;
		DLJBEFQJPML.nearClipPlane = IBLLKJCQNHP.nearClipPlane;
		DLJBEFQJPML.orthographic = IBLLKJCQNHP.orthographic;
		DLJBEFQJPML.fieldOfView = IBLLKJCQNHP.fieldOfView;
		DLJBEFQJPML.aspect = IBLLKJCQNHP.aspect;
		DLJBEFQJPML.orthographicSize = IBLLKJCQNHP.orthographicSize;
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00041B24 File Offset: 0x0003FD24
	public void GNCGJNMPOKI()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (LBDMDNMJINK.QFPBHEIGQIK)
		{
			return;
		}
		LBDMDNMJINK.QFPBHEIGQIK = true;
		this.NLLKOOEHOCE = this.JQGHQLFHCHE();
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.OPQPODNDOPQ();
		Camera camera;
		Camera camera2;
		this.JLEEGGCOOBN(current, out camera, out camera2);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = 1;
		}
		this.DIPEQCFCCCC(current, camera);
		this.EQPNDPGNCBB(current, camera2);
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			float w = -Vector3.Dot(up, position) - this.FONKIGGPJNQ;
			Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			LBDMDNMJINK.OOELFBENHIG(ref zero, nioiglmodlj);
			Vector3 position2 = current.transform.position;
			Vector3 position3 = zero.MultiplyPoint(position2);
			camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
			Vector4 clipPlane = this.KCIJPGNGENK(camera, position, up, 1707f);
			camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
			camera.cullingMask = (-10 & this.QNOLOCMMMKM.value);
			camera.targetTexture = this.LHLGQMLGCJG;
			bool invertCulling;
			GL.invertCulling = !(invertCulling = GL.invertCulling);
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			camera.Render();
			camera.transform.position = position2;
			GL.invertCulling = invertCulling;
			base.GetComponent<Renderer>().sharedMaterial.SetTexture(" was prevented from healing!\r\n", this.LHLGQMLGCJG);
		}
		if (mkjbfkgfbpf >= (LBDMDNMJINK.MKJBFKGFBPF)3)
		{
			camera2.worldToCameraMatrix = current.worldToCameraMatrix;
			Vector4 clipPlane2 = this.MLCPEMBGINL(camera2, position, up, 335f);
			camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
			camera2.cullingMask = (-19 & this.NCDOOJEBFPE.value);
			camera2.targetTexture = this.HDIKQFMDFQJ;
			camera2.transform.position = current.transform.position;
			camera2.transform.rotation = current.transform.rotation;
			camera2.Render();
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("desolateland", this.HDIKQFMDFQJ);
		}
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Reflective)
			{
				if (mkjbfkgfbpf == (LBDMDNMJINK.MKJBFKGFBPF)5)
				{
					Shader.DisableKeyword("[00]");
					Shader.DisableKeyword("e");
					Shader.EnableKeyword("Beacon Badge");
				}
			}
			else
			{
				Shader.DisableKeyword("/");
				Shader.EnableKeyword("_History3LumaTex");
				Shader.DisableKeyword("Member");
			}
		}
		else
		{
			Shader.EnableKeyword("trick");
			Shader.DisableKeyword("[-] is trying to evolve into [FF9900]");
			Shader.DisableKeyword("Move Learning");
		}
		LBDMDNMJINK.QFPBHEIGQIK = false;
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00041E44 File Offset: 0x00040044
	private void BJFCILIPEMI()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return;
		}
		Vector4 vector = sharedMaterial.GetVector(" and found it's ");
		float @float = sharedMaterial.GetFloat("/guildrank ");
		Vector4 value = new Vector4(@float, @float, @float * 1828f, @float * 817f);
		double num = (double)Time.timeSinceLevelLoad / 1440.0;
		Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 1739.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 83.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 620.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 1263.0));
		sharedMaterial.SetVector("flameburst", value2);
		sharedMaterial.SetVector("Sun", value);
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00041F60 File Offset: 0x00040160
	private LBDMDNMJINK.MKJBFKGFBPF NEDPDNHOOQE()
	{
		if (!base.GetComponent<Renderer>())
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
		}
		string tag = sharedMaterial.GetTag("hydration", true);
		if (tag == "sniper")
		{
			return (LBDMDNMJINK.MKJBFKGFBPF)3;
		}
		if (tag == " took ")
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		return LBDMDNMJINK.MKJBFKGFBPF.Simple;
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00041FC0 File Offset: 0x000401C0
	private void JLEEGGCOOBN(Camera EBNOGGPBLNC, out Camera BCKOIGBNIPQ, out Camera GEKQNPJBJEI)
	{
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.MOLLIMJIIFB();
		BCKOIGBNIPQ = null;
		GEKQNPJBJEI = null;
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (!this.LHLGQMLGCJG || this.CNNBOPBDLQE != this.JMLPENNCCLP)
			{
				if (this.LHLGQMLGCJG)
				{
					UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
				}
				this.LHLGQMLGCJG = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, -83);
				this.LHLGQMLGCJG.name = "[00DD00]Owned" + base.GetInstanceID();
				this.LHLGQMLGCJG.isPowerOfTwo = false;
				this.LHLGQMLGCJG.hideFlags = (HideFlags)95;
				this.CNNBOPBDLQE = this.JMLPENNCCLP;
			}
			this.GQGPPLOPBDG.TryGetValue(EBNOGGPBLNC, out BCKOIGBNIPQ);
			if (!BCKOIGBNIPQ)
			{
				object[] array = new object[4];
				array[1] = "BuffIcon_Fly";
				array[1] = base.GetInstanceID();
				array[8] = " (SoftClip)";
				array[1] = EBNOGGPBLNC.GetInstanceID();
				string name = string.Concat(array);
				Type[] array2 = new Type[4];
				array2[1] = typeof(Camera);
				array2[1] = typeof(Skybox);
				GameObject gameObject = new GameObject(name, array2);
				BCKOIGBNIPQ = gameObject.GetComponent<Camera>();
				BCKOIGBNIPQ.enabled = false;
				BCKOIGBNIPQ.transform.position = base.transform.position;
				BCKOIGBNIPQ.transform.rotation = base.transform.rotation;
				BCKOIGBNIPQ.gameObject.AddComponent<FlareLayer>();
				gameObject.hideFlags = (HideFlags)95;
				this.GQGPPLOPBDG[EBNOGGPBLNC] = BCKOIGBNIPQ;
			}
		}
		if (mkjbfkgfbpf >= (LBDMDNMJINK.MKJBFKGFBPF)7)
		{
			if (!this.HDIKQFMDFQJ || this.CMKJLPNONPM != this.JMLPENNCCLP)
			{
				if (this.HDIKQFMDFQJ)
				{
					UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
				}
				this.HDIKQFMDFQJ = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, -49);
				this.HDIKQFMDFQJ.name = "Login" + base.GetInstanceID();
				this.HDIKQFMDFQJ.isPowerOfTwo = true;
				this.HDIKQFMDFQJ.hideFlags = (HideFlags)(-71);
				this.CMKJLPNONPM = this.JMLPENNCCLP;
			}
			this.OKODNGMFQIB.TryGetValue(EBNOGGPBLNC, out GEKQNPJBJEI);
			if (!GEKQNPJBJEI)
			{
				object[] array3 = new object[2];
				array3[0] = "clearpoke";
				array3[0] = base.GetInstanceID();
				array3[4] = "pacman";
				array3[3] = EBNOGGPBLNC.GetInstanceID();
				string name2 = string.Concat(array3);
				Type[] array4 = new Type[3];
				array4[1] = typeof(Camera);
				array4[0] = typeof(Skybox);
				GameObject gameObject2 = new GameObject(name2, array4);
				GEKQNPJBJEI = gameObject2.GetComponent<Camera>();
				GEKQNPJBJEI.enabled = false;
				GEKQNPJBJEI.transform.position = base.transform.position;
				GEKQNPJBJEI.transform.rotation = base.transform.rotation;
				GEKQNPJBJEI.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = HideFlags.None;
				this.OKODNGMFQIB[EBNOGGPBLNC] = GEKQNPJBJEI;
			}
		}
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00041180 File Offset: 0x0003F380
	private void KJCGOKLPNEE(Camera IBLLKJCQNHP, Camera DLJBEFQJPML)
	{
		if (DLJBEFQJPML == null)
		{
			return;
		}
		DLJBEFQJPML.clearFlags = IBLLKJCQNHP.clearFlags;
		DLJBEFQJPML.backgroundColor = IBLLKJCQNHP.backgroundColor;
		if (IBLLKJCQNHP.clearFlags == (CameraClearFlags)0)
		{
			Skybox component = IBLLKJCQNHP.GetComponent<Skybox>();
			Skybox component2 = DLJBEFQJPML.GetComponent<Skybox>();
			if (component && component.material)
			{
				component2.enabled = false;
				component2.material = component.material;
			}
			else
			{
				component2.enabled = true;
			}
		}
		DLJBEFQJPML.farClipPlane = IBLLKJCQNHP.farClipPlane;
		DLJBEFQJPML.nearClipPlane = IBLLKJCQNHP.nearClipPlane;
		DLJBEFQJPML.orthographic = IBLLKJCQNHP.orthographic;
		DLJBEFQJPML.fieldOfView = IBLLKJCQNHP.fieldOfView;
		DLJBEFQJPML.aspect = IBLLKJCQNHP.aspect;
		DLJBEFQJPML.orthographicSize = IBLLKJCQNHP.orthographicSize;
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x000422BC File Offset: 0x000404BC
	private static void NFMNBMNOOHL(ref Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1401f - 630f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 882f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = 1089f * NIOIGLMODLJ[1] * NIOIGLMODLJ[4];
		IODFJKQOEMK.m03 = 1420f * NIOIGLMODLJ[7] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 903f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1991f - 636f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = 516f * NIOIGLMODLJ[1] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m13 = 83f * NIOIGLMODLJ[4] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m20 = 1473f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 429f * NIOIGLMODLJ[8] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 1998f - 1682f * NIOIGLMODLJ[0] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m23 = 1340f * NIOIGLMODLJ[2] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m30 = 28f;
		IODFJKQOEMK.m31 = 69f;
		IODFJKQOEMK.m32 = 1360f;
		IODFJKQOEMK.m33 = 722f;
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00042464 File Offset: 0x00040664
	private static void IBQDHBOPPJN(ref Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1190f - 1852f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 1798f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = 1690f * NIOIGLMODLJ[1] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m03 = 1211f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m10 = 276f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 279f - 1816f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m12 = 1093f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m13 = 1048f * NIOIGLMODLJ[8] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m20 = 1867f * NIOIGLMODLJ[3] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m21 = 261f * NIOIGLMODLJ[2] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m22 = 1457f - 401f * NIOIGLMODLJ[8] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m23 = 773f * NIOIGLMODLJ[1] * NIOIGLMODLJ[5];
		IODFJKQOEMK.m30 = 924f;
		IODFJKQOEMK.m31 = 1438f;
		IODFJKQOEMK.m32 = 1332f;
		IODFJKQOEMK.m33 = 1318f;
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x0004260C File Offset: 0x0004080C
	private void PLCCHDMMBKF()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return;
		}
		Vector4 vector = sharedMaterial.GetVector("~");
		float @float = sharedMaterial.GetFloat("[PG]");
		Vector4 value = new Vector4(@float, @float, @float * 1528f, @float * 325f);
		double num = (double)Time.timeSinceLevelLoad / 127.0;
		Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 425.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 372.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 843.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 1055.0));
		sharedMaterial.SetVector("CombinersArgsAlphaSrc2", value2);
		sharedMaterial.SetVector("#", value);
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x00003E41 File Offset: 0x00002041
	private LBDMDNMJINK.MKJBFKGFBPF PLMOGKHBQEQ()
	{
		if (this.NLLKOOEHOCE < this.EBIMEODKNMO)
		{
			return this.NLLKOOEHOCE;
		}
		return this.EBIMEODKNMO;
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00042728 File Offset: 0x00040928
	private LBDMDNMJINK.MKJBFKGFBPF LLFNDLOPKPQ()
	{
		if (!base.GetComponent<Renderer>())
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
		}
		string tag = sharedMaterial.GetTag(".", false);
		if (tag == "Null")
		{
			return (LBDMDNMJINK.MKJBFKGFBPF)3;
		}
		if (tag == "Trace")
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
		}
		return LBDMDNMJINK.MKJBFKGFBPF.Simple;
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00003E41 File Offset: 0x00002041
	private LBDMDNMJINK.MKJBFKGFBPF MOLLIMJIIFB()
	{
		if (this.NLLKOOEHOCE < this.EBIMEODKNMO)
		{
			return this.NLLKOOEHOCE;
		}
		return this.EBIMEODKNMO;
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00042788 File Offset: 0x00040988
	private void PPLIBEGDKHC()
	{
		if (this.LHLGQMLGCJG)
		{
			UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
			this.LHLGQMLGCJG = null;
		}
		if (this.HDIKQFMDFQJ)
		{
			UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
			this.HDIKQFMDFQJ = null;
		}
		foreach (KeyValuePair<Camera, Camera> keyValuePair in this.GQGPPLOPBDG)
		{
			UnityEngine.Object.DestroyImmediate(keyValuePair.Value.gameObject);
		}
		this.GQGPPLOPBDG.Clear();
		foreach (KeyValuePair<Camera, Camera> keyValuePair2 in this.OKODNGMFQIB)
		{
			UnityEngine.Object.DestroyImmediate(keyValuePair2.Value.gameObject);
		}
		this.OKODNGMFQIB.Clear();
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00042888 File Offset: 0x00040A88
	private void Update()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return;
		}
		Vector4 vector = sharedMaterial.GetVector("WaveSpeed");
		float @float = sharedMaterial.GetFloat("_WaveScale");
		Vector4 value = new Vector4(@float, @float, @float * 0.4f, @float * 0.45f);
		double num = (double)Time.timeSinceLevelLoad / 20.0;
		Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 1.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 1.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 1.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 1.0));
		sharedMaterial.SetVector("_WaveOffset", value2);
		sharedMaterial.SetVector("_WaveScale4", value);
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x000429A4 File Offset: 0x00040BA4
	private void QCIBQDEQIDJ(Camera IBLLKJCQNHP, Camera DLJBEFQJPML)
	{
		if (DLJBEFQJPML == null)
		{
			return;
		}
		DLJBEFQJPML.clearFlags = IBLLKJCQNHP.clearFlags;
		DLJBEFQJPML.backgroundColor = IBLLKJCQNHP.backgroundColor;
		if (IBLLKJCQNHP.clearFlags == (CameraClearFlags)0)
		{
			Skybox component = IBLLKJCQNHP.GetComponent<Skybox>();
			Skybox component2 = DLJBEFQJPML.GetComponent<Skybox>();
			if (component && component.material)
			{
				component2.enabled = true;
				component2.material = component.material;
			}
			else
			{
				component2.enabled = false;
			}
		}
		DLJBEFQJPML.farClipPlane = IBLLKJCQNHP.farClipPlane;
		DLJBEFQJPML.nearClipPlane = IBLLKJCQNHP.nearClipPlane;
		DLJBEFQJPML.orthographic = IBLLKJCQNHP.orthographic;
		DLJBEFQJPML.fieldOfView = IBLLKJCQNHP.fieldOfView;
		DLJBEFQJPML.aspect = IBLLKJCQNHP.aspect;
		DLJBEFQJPML.orthographicSize = IBLLKJCQNHP.orthographicSize;
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00042A64 File Offset: 0x00040C64
	private void HHQECIKHKIJ(Camera EBNOGGPBLNC, out Camera BCKOIGBNIPQ, out Camera GEKQNPJBJEI)
	{
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.OPQPODNDOPQ();
		BCKOIGBNIPQ = null;
		GEKQNPJBJEI = null;
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Reflective)
		{
			if (!this.LHLGQMLGCJG || this.CNNBOPBDLQE != this.JMLPENNCCLP)
			{
				if (this.LHLGQMLGCJG)
				{
					UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
				}
				this.LHLGQMLGCJG = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 52);
				this.LHLGQMLGCJG.name = ":" + base.GetInstanceID();
				this.LHLGQMLGCJG.isPowerOfTwo = false;
				this.LHLGQMLGCJG.hideFlags = (HideFlags)(-106);
				this.CNNBOPBDLQE = this.JMLPENNCCLP;
			}
			this.GQGPPLOPBDG.TryGetValue(EBNOGGPBLNC, out BCKOIGBNIPQ);
			if (!BCKOIGBNIPQ)
			{
				object[] array = new object[]
				{
					null,
					"Duplicate!"
				};
				array[0] = base.GetInstanceID();
				array[0] = "[PD]";
				array[0] = EBNOGGPBLNC.GetInstanceID();
				string name = string.Concat(array);
				Type[] array2 = new Type[3];
				array2[1] = typeof(Camera);
				array2[0] = typeof(Skybox);
				GameObject gameObject = new GameObject(name, array2);
				BCKOIGBNIPQ = gameObject.GetComponent<Camera>();
				BCKOIGBNIPQ.enabled = false;
				BCKOIGBNIPQ.transform.position = base.transform.position;
				BCKOIGBNIPQ.transform.rotation = base.transform.rotation;
				BCKOIGBNIPQ.gameObject.AddComponent<FlareLayer>();
				gameObject.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				this.GQGPPLOPBDG[EBNOGGPBLNC] = BCKOIGBNIPQ;
			}
		}
		if (mkjbfkgfbpf >= (LBDMDNMJINK.MKJBFKGFBPF)7)
		{
			if (!this.HDIKQFMDFQJ || this.CMKJLPNONPM != this.JMLPENNCCLP)
			{
				if (this.HDIKQFMDFQJ)
				{
					UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
				}
				this.HDIKQFMDFQJ = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, -77);
				this.HDIKQFMDFQJ.name = "Its disguise served it as a decoy!\r\n" + base.GetInstanceID();
				this.HDIKQFMDFQJ.isPowerOfTwo = false;
				this.HDIKQFMDFQJ.hideFlags = (HideFlags)(-90);
				this.CMKJLPNONPM = this.JMLPENNCCLP;
			}
			this.OKODNGMFQIB.TryGetValue(EBNOGGPBLNC, out GEKQNPJBJEI);
			if (!GEKQNPJBJEI)
			{
				object[] array3 = new object[4];
				array3[1] = "Items held by the Pokémon are stuck fast and cannot be removed by other Pokémon.";
				array3[1] = base.GetInstanceID();
				array3[8] = "MapCache";
				array3[1] = EBNOGGPBLNC.GetInstanceID();
				string name2 = string.Concat(array3);
				Type[] array4 = new Type[]
				{
					null,
					typeof(Camera)
				};
				array4[0] = typeof(Skybox);
				GameObject gameObject2 = new GameObject(name2, array4);
				GEKQNPJBJEI = gameObject2.GetComponent<Camera>();
				GEKQNPJBJEI.enabled = false;
				GEKQNPJBJEI.transform.position = base.transform.position;
				GEKQNPJBJEI.transform.rotation = base.transform.rotation;
				GEKQNPJBJEI.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = HideFlags.DontSaveInEditor;
				this.OKODNGMFQIB[EBNOGGPBLNC] = GEKQNPJBJEI;
			}
		}
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00042D60 File Offset: 0x00040F60
	private Vector4 GDMJHENLGKH(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00042DCC File Offset: 0x00040FCC
	private void HGKPKMMIPLG()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return;
		}
		Vector4 vector = sharedMaterial.GetVector(")");
		float @float = sharedMaterial.GetFloat("Water Refr Camera id");
		Vector4 value = new Vector4(@float, @float, @float * 1579f, @float * 1903f);
		double num = (double)Time.timeSinceLevelLoad / 259.0;
		Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 1223.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 1456.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 108.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 121.0));
		sharedMaterial.SetVector("Layer_", value2);
		sharedMaterial.SetVector("HidePanel", value);
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00003E41 File Offset: 0x00002041
	private LBDMDNMJINK.MKJBFKGFBPF EQCJIEOJDIF()
	{
		if (this.NLLKOOEHOCE < this.EBIMEODKNMO)
		{
			return this.NLLKOOEHOCE;
		}
		return this.EBIMEODKNMO;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00042EE8 File Offset: 0x000410E8
	public void OGNEHCKMLLQ()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (LBDMDNMJINK.QFPBHEIGQIK)
		{
			return;
		}
		LBDMDNMJINK.QFPBHEIGQIK = true;
		this.NLLKOOEHOCE = this.LLFNDLOPKPQ();
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.MOLLIMJIIFB();
		Camera camera;
		Camera camera2;
		this.HHQECIKHKIJ(current, out camera, out camera2);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = 0;
		}
		this.ELGDDBCPLFE(current, camera);
		this.MOHQIGHMDLI(current, camera2);
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			float w = -Vector3.Dot(up, position) - this.FONKIGGPJNQ;
			Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			LBDMDNMJINK.IBQDHBOPPJN(ref zero, nioiglmodlj);
			Vector3 position2 = current.transform.position;
			Vector3 position3 = zero.MultiplyPoint(position2);
			camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
			Vector4 clipPlane = this.NLLQCPGQPLJ(camera, position, up, 425f);
			camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
			camera.cullingMask = (3 & this.QNOLOCMMMKM.value);
			camera.targetTexture = this.LHLGQMLGCJG;
			bool invertCulling;
			GL.invertCulling = !(invertCulling = GL.invertCulling);
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			camera.Render();
			camera.transform.position = position2;
			GL.invertCulling = invertCulling;
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("Slots_3", this.LHLGQMLGCJG);
		}
		if (mkjbfkgfbpf >= (LBDMDNMJINK.MKJBFKGFBPF)8)
		{
			camera2.worldToCameraMatrix = current.worldToCameraMatrix;
			Vector4 clipPlane2 = this.MLCPEMBGINL(camera2, position, up, 86f);
			camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
			camera2.cullingMask = (104 & this.NCDOOJEBFPE.value);
			camera2.targetTexture = this.HDIKQFMDFQJ;
			camera2.transform.position = current.transform.position;
			camera2.transform.rotation = current.transform.rotation;
			camera2.Render();
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("This Pokémon inflicts damage with its rough skin to the attacker on contact.", this.HDIKQFMDFQJ);
		}
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
			{
				if (mkjbfkgfbpf == LBDMDNMJINK.MKJBFKGFBPF.Reflective)
				{
					Shader.DisableKeyword("All stat changes were eliminated!\r\n");
					Shader.DisableKeyword("_Texture0");
					Shader.EnableKeyword("psn");
				}
			}
			else
			{
				Shader.DisableKeyword("_Distance");
				Shader.EnableKeyword("50% more chance to encounter a Steel-type Pokémon.\nTriggers: [2ecc71]Magnet Pull[-]");
				Shader.DisableKeyword("Verification");
			}
		}
		else
		{
			Shader.EnableKeyword(",");
			Shader.DisableKeyword("Grass Pelt");
			Shader.DisableKeyword("_MountBottomTex");
		}
		LBDMDNMJINK.QFPBHEIGQIK = true;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00042D60 File Offset: 0x00040F60
	private Vector4 CMLFIOFHLLN(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00043208 File Offset: 0x00041408
	public void EFJFFNQIBGK()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (LBDMDNMJINK.QFPBHEIGQIK)
		{
			return;
		}
		LBDMDNMJINK.QFPBHEIGQIK = true;
		this.NLLKOOEHOCE = this.JQGHQLFHCHE();
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.PLMOGKHBQEQ();
		Camera camera;
		Camera camera2;
		this.CDGHCBBHGHN(current, out camera, out camera2);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = 1;
		}
		this.KLDJMLIHGHF(current, camera);
		this.DIPEQCFCCCC(current, camera2);
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Reflective)
		{
			float w = -Vector3.Dot(up, position) - this.FONKIGGPJNQ;
			Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			LBDMDNMJINK.MLBGPCOHLME(ref zero, nioiglmodlj);
			Vector3 position2 = current.transform.position;
			Vector3 position3 = zero.MultiplyPoint(position2);
			camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
			Vector4 clipPlane = this.NLLQCPGQPLJ(camera, position, up, 733f);
			camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
			camera.cullingMask = (-114 & this.QNOLOCMMMKM.value);
			camera.targetTexture = this.LHLGQMLGCJG;
			bool invertCulling;
			GL.invertCulling = (invertCulling = GL.invertCulling);
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			camera.Render();
			camera.transform.position = position2;
			GL.invertCulling = invertCulling;
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("Premultiplied", this.LHLGQMLGCJG);
		}
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			camera2.worldToCameraMatrix = current.worldToCameraMatrix;
			Vector4 clipPlane2 = this.IEJPJEDBGON(camera2, position, up, 384f);
			camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
			camera2.cullingMask = (34 & this.NCDOOJEBFPE.value);
			camera2.targetTexture = this.HDIKQFMDFQJ;
			camera2.transform.position = current.transform.position;
			camera2.transform.rotation = current.transform.rotation;
			camera2.Render();
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("Water Compaction", this.HDIKQFMDFQJ);
		}
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
			{
				if (mkjbfkgfbpf == (LBDMDNMJINK.MKJBFKGFBPF)7)
				{
					Shader.DisableKeyword("Run_White");
					Shader.DisableKeyword("Battle");
					Shader.EnableKeyword("[eat]");
				}
			}
			else
			{
				Shader.DisableKeyword("[00EE07]");
				Shader.EnableKeyword("Can't resolve the item ID of ");
				Shader.DisableKeyword("None");
			}
		}
		else
		{
			Shader.EnableKeyword("_");
			Shader.DisableKeyword(" on ");
			Shader.DisableKeyword("Hidden/Post FX/Builtin Debug Views");
		}
		LBDMDNMJINK.QFPBHEIGQIK = false;
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00043528 File Offset: 0x00041728
	private void JCFNLPQFNEI(Camera EBNOGGPBLNC, out Camera BCKOIGBNIPQ, out Camera GEKQNPJBJEI)
	{
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.OPQPODNDOPQ();
		BCKOIGBNIPQ = null;
		GEKQNPJBJEI = null;
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (!this.LHLGQMLGCJG || this.CNNBOPBDLQE != this.JMLPENNCCLP)
			{
				if (this.LHLGQMLGCJG)
				{
					UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
				}
				this.LHLGQMLGCJG = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, -66);
				this.LHLGQMLGCJG.name = "adjacentAllyOrSelf" + base.GetInstanceID();
				this.LHLGQMLGCJG.isPowerOfTwo = false;
				this.LHLGQMLGCJG.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				this.CNNBOPBDLQE = this.JMLPENNCCLP;
			}
			this.GQGPPLOPBDG.TryGetValue(EBNOGGPBLNC, out BCKOIGBNIPQ);
			if (!BCKOIGBNIPQ)
			{
				object[] array = new object[6];
				array[1] = "4";
				array[1] = base.GetInstanceID();
				array[4] = "battlebag";
				array[2] = EBNOGGPBLNC.GetInstanceID();
				string name = string.Concat(array);
				Type[] array2 = new Type[4];
				array2[0] = typeof(Camera);
				array2[1] = typeof(Skybox);
				GameObject gameObject = new GameObject(name, array2);
				BCKOIGBNIPQ = gameObject.GetComponent<Camera>();
				BCKOIGBNIPQ.enabled = true;
				BCKOIGBNIPQ.transform.position = base.transform.position;
				BCKOIGBNIPQ.transform.rotation = base.transform.rotation;
				BCKOIGBNIPQ.gameObject.AddComponent<FlareLayer>();
				gameObject.hideFlags = (HideFlags)116;
				this.GQGPPLOPBDG[EBNOGGPBLNC] = BCKOIGBNIPQ;
			}
		}
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (!this.HDIKQFMDFQJ || this.CMKJLPNONPM != this.JMLPENNCCLP)
			{
				if (this.HDIKQFMDFQJ)
				{
					UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
				}
				this.HDIKQFMDFQJ = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 12);
				this.HDIKQFMDFQJ.name = "#,##0" + base.GetInstanceID();
				this.HDIKQFMDFQJ.isPowerOfTwo = false;
				this.HDIKQFMDFQJ.hideFlags = HideFlags.HideInInspector;
				this.CMKJLPNONPM = this.JMLPENNCCLP;
			}
			this.OKODNGMFQIB.TryGetValue(EBNOGGPBLNC, out GEKQNPJBJEI);
			if (!GEKQNPJBJEI)
			{
				object[] array3 = new object[4];
				array3[0] = "_FresnelFadePower";
				array3[0] = base.GetInstanceID();
				array3[5] = "Regenerator";
				array3[4] = EBNOGGPBLNC.GetInstanceID();
				string name2 = string.Concat(array3);
				Type[] array4 = new Type[8];
				array4[0] = typeof(Camera);
				array4[0] = typeof(Skybox);
				GameObject gameObject2 = new GameObject(name2, array4);
				GEKQNPJBJEI = gameObject2.GetComponent<Camera>();
				GEKQNPJBJEI.enabled = true;
				GEKQNPJBJEI.transform.position = base.transform.position;
				GEKQNPJBJEI.transform.rotation = base.transform.rotation;
				GEKQNPJBJEI.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = (HideFlags)83;
				this.OKODNGMFQIB[EBNOGGPBLNC] = GEKQNPJBJEI;
			}
		}
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00043824 File Offset: 0x00041A24
	public void OnWillRenderObject()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (LBDMDNMJINK.QFPBHEIGQIK)
		{
			return;
		}
		LBDMDNMJINK.QFPBHEIGQIK = true;
		this.NLLKOOEHOCE = this.ENJPPHNKHOH();
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.PLMOGKHBQEQ();
		Camera camera;
		Camera camera2;
		this.CLHQMCOJHHE(current, out camera, out camera2);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = 0;
		}
		this.EMMFQHQIBEQ(current, camera);
		this.EMMFQHQIBEQ(current, camera2);
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Reflective)
		{
			float w = -Vector3.Dot(up, position) - this.FONKIGGPJNQ;
			Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			LBDMDNMJINK.HPJEFFCPBQJ(ref zero, nioiglmodlj);
			Vector3 position2 = current.transform.position;
			Vector3 position3 = zero.MultiplyPoint(position2);
			camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
			Vector4 clipPlane = this.MLCPEMBGINL(camera, position, up, 1f);
			camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
			camera.cullingMask = (-17 & this.QNOLOCMMMKM.value);
			camera.targetTexture = this.LHLGQMLGCJG;
			bool invertCulling;
			GL.invertCulling = !(invertCulling = GL.invertCulling);
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			camera.Render();
			camera.transform.position = position2;
			GL.invertCulling = invertCulling;
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("_ReflectionTex", this.LHLGQMLGCJG);
		}
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Refractive)
		{
			camera2.worldToCameraMatrix = current.worldToCameraMatrix;
			Vector4 clipPlane2 = this.MLCPEMBGINL(camera2, position, up, -1f);
			camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
			camera2.cullingMask = (-17 & this.NCDOOJEBFPE.value);
			camera2.targetTexture = this.HDIKQFMDFQJ;
			camera2.transform.position = current.transform.position;
			camera2.transform.rotation = current.transform.rotation;
			camera2.Render();
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("_RefractionTex", this.HDIKQFMDFQJ);
		}
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Reflective)
			{
				if (mkjbfkgfbpf == LBDMDNMJINK.MKJBFKGFBPF.Refractive)
				{
					Shader.DisableKeyword("WATER_SIMPLE");
					Shader.DisableKeyword("WATER_REFLECTIVE");
					Shader.EnableKeyword("WATER_REFRACTIVE");
				}
			}
			else
			{
				Shader.DisableKeyword("WATER_SIMPLE");
				Shader.EnableKeyword("WATER_REFLECTIVE");
				Shader.DisableKeyword("WATER_REFRACTIVE");
			}
		}
		else
		{
			Shader.EnableKeyword("WATER_SIMPLE");
			Shader.DisableKeyword("WATER_REFLECTIVE");
			Shader.DisableKeyword("WATER_REFRACTIVE");
		}
		LBDMDNMJINK.QFPBHEIGQIK = false;
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00043B44 File Offset: 0x00041D44
	private static void LHDJLJOBFCH(ref Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1625f - 955f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m01 = 784f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = 1035f * NIOIGLMODLJ[1] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m03 = 726f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 1519f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m11 = 1546f - 526f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m12 = 450f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m13 = 1838f * NIOIGLMODLJ[6] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m20 = 1141f * NIOIGLMODLJ[6] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 1020f * NIOIGLMODLJ[2] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 1094f - 426f * NIOIGLMODLJ[8] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m23 = 1883f * NIOIGLMODLJ[3] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m30 = 1142f;
		IODFJKQOEMK.m31 = 297f;
		IODFJKQOEMK.m32 = 1679f;
		IODFJKQOEMK.m33 = 1452f;
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00043CEC File Offset: 0x00041EEC
	private void DBFDKMLMLFK(Camera EBNOGGPBLNC, out Camera BCKOIGBNIPQ, out Camera GEKQNPJBJEI)
	{
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.JNQHKFKHHFD();
		BCKOIGBNIPQ = null;
		GEKQNPJBJEI = null;
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Reflective)
		{
			if (!this.LHLGQMLGCJG || this.CNNBOPBDLQE != this.JMLPENNCCLP)
			{
				if (this.LHLGQMLGCJG)
				{
					UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
				}
				this.LHLGQMLGCJG = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 12);
				this.LHLGQMLGCJG.name = ", shiny" + base.GetInstanceID();
				this.LHLGQMLGCJG.isPowerOfTwo = true;
				this.LHLGQMLGCJG.hideFlags = ~HideFlags.HideInInspector;
				this.CNNBOPBDLQE = this.JMLPENNCCLP;
			}
			this.GQGPPLOPBDG.TryGetValue(EBNOGGPBLNC, out BCKOIGBNIPQ);
			if (!BCKOIGBNIPQ)
			{
				object[] array = new object[1];
				array[1] = "b";
				array[1] = base.GetInstanceID();
				array[0] = "party";
				array[0] = EBNOGGPBLNC.GetInstanceID();
				string name = string.Concat(array);
				Type[] array2 = new Type[8];
				array2[1] = typeof(Camera);
				array2[1] = typeof(Skybox);
				GameObject gameObject = new GameObject(name, array2);
				BCKOIGBNIPQ = gameObject.GetComponent<Camera>();
				BCKOIGBNIPQ.enabled = true;
				BCKOIGBNIPQ.transform.position = base.transform.position;
				BCKOIGBNIPQ.transform.rotation = base.transform.rotation;
				BCKOIGBNIPQ.gameObject.AddComponent<FlareLayer>();
				gameObject.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				this.GQGPPLOPBDG[EBNOGGPBLNC] = BCKOIGBNIPQ;
			}
		}
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Refractive)
		{
			if (!this.HDIKQFMDFQJ || this.CMKJLPNONPM != this.JMLPENNCCLP)
			{
				if (this.HDIKQFMDFQJ)
				{
					UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
				}
				this.HDIKQFMDFQJ = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 7);
				this.HDIKQFMDFQJ.name = "par" + base.GetInstanceID();
				this.HDIKQFMDFQJ.isPowerOfTwo = false;
				this.HDIKQFMDFQJ.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				this.CMKJLPNONPM = this.JMLPENNCCLP;
			}
			this.OKODNGMFQIB.TryGetValue(EBNOGGPBLNC, out GEKQNPJBJEI);
			if (!GEKQNPJBJEI)
			{
				object[] array3 = new object[6];
				array3[0] = "[orange]";
				array3[1] = base.GetInstanceID();
				array3[3] = " into the sky!\r\n";
				array3[7] = EBNOGGPBLNC.GetInstanceID();
				string name2 = string.Concat(array3);
				Type[] array4 = new Type[4];
				array4[1] = typeof(Camera);
				array4[0] = typeof(Skybox);
				GameObject gameObject2 = new GameObject(name2, array4);
				GEKQNPJBJEI = gameObject2.GetComponent<Camera>();
				GEKQNPJBJEI.enabled = true;
				GEKQNPJBJEI.transform.position = base.transform.position;
				GEKQNPJBJEI.transform.rotation = base.transform.rotation;
				GEKQNPJBJEI.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
				this.OKODNGMFQIB[EBNOGGPBLNC] = GEKQNPJBJEI;
			}
		}
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00043FE8 File Offset: 0x000421E8
	private static void OOELFBENHIG(ref Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1670f - 1637f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 812f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m02 = 1346f * NIOIGLMODLJ[0] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m03 = 852f * NIOIGLMODLJ[8] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 339f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 144f - 49f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = 922f * NIOIGLMODLJ[0] * NIOIGLMODLJ[8];
		IODFJKQOEMK.m13 = 927f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m20 = 415f * NIOIGLMODLJ[4] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 544f * NIOIGLMODLJ[2] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 909f - 709f * NIOIGLMODLJ[4] * NIOIGLMODLJ[8];
		IODFJKQOEMK.m23 = 1817f * NIOIGLMODLJ[1] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m30 = 1693f;
		IODFJKQOEMK.m31 = 1686f;
		IODFJKQOEMK.m32 = 1411f;
		IODFJKQOEMK.m33 = 886f;
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00042D60 File Offset: 0x00040F60
	private Vector4 OIBQLJBCBKL(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00042D60 File Offset: 0x00040F60
	private Vector4 IEJPJEDBGON(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00044190 File Offset: 0x00042390
	private static void MLBGPCOHLME(ref Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1504f - 1706f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 1838f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m02 = 1961f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m03 = 687f * NIOIGLMODLJ[5] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 304f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1068f - 722f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m12 = 286f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m13 = 216f * NIOIGLMODLJ[2] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m20 = 1844f * NIOIGLMODLJ[2] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 1431f * NIOIGLMODLJ[8] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 366f - 758f * NIOIGLMODLJ[5] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m23 = 1927f * NIOIGLMODLJ[3] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m30 = 149f;
		IODFJKQOEMK.m31 = 1287f;
		IODFJKQOEMK.m32 = 849f;
		IODFJKQOEMK.m33 = 978f;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00041A64 File Offset: 0x0003FC64
	private void EQPNDPGNCBB(Camera IBLLKJCQNHP, Camera DLJBEFQJPML)
	{
		if (DLJBEFQJPML == null)
		{
			return;
		}
		DLJBEFQJPML.clearFlags = IBLLKJCQNHP.clearFlags;
		DLJBEFQJPML.backgroundColor = IBLLKJCQNHP.backgroundColor;
		if (IBLLKJCQNHP.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox component = IBLLKJCQNHP.GetComponent<Skybox>();
			Skybox component2 = DLJBEFQJPML.GetComponent<Skybox>();
			if (component && component.material)
			{
				component2.enabled = true;
				component2.material = component.material;
			}
			else
			{
				component2.enabled = false;
			}
		}
		DLJBEFQJPML.farClipPlane = IBLLKJCQNHP.farClipPlane;
		DLJBEFQJPML.nearClipPlane = IBLLKJCQNHP.nearClipPlane;
		DLJBEFQJPML.orthographic = IBLLKJCQNHP.orthographic;
		DLJBEFQJPML.fieldOfView = IBLLKJCQNHP.fieldOfView;
		DLJBEFQJPML.aspect = IBLLKJCQNHP.aspect;
		DLJBEFQJPML.orthographicSize = IBLLKJCQNHP.orthographicSize;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00003E41 File Offset: 0x00002041
	private LBDMDNMJINK.MKJBFKGFBPF OCMQPILQPOQ()
	{
		if (this.NLLKOOEHOCE < this.EBIMEODKNMO)
		{
			return this.NLLKOOEHOCE;
		}
		return this.EBIMEODKNMO;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00044338 File Offset: 0x00042538
	private void KLDJMLIHGHF(Camera IBLLKJCQNHP, Camera DLJBEFQJPML)
	{
		if (DLJBEFQJPML == null)
		{
			return;
		}
		DLJBEFQJPML.clearFlags = IBLLKJCQNHP.clearFlags;
		DLJBEFQJPML.backgroundColor = IBLLKJCQNHP.backgroundColor;
		if (IBLLKJCQNHP.clearFlags == (CameraClearFlags)0)
		{
			Skybox component = IBLLKJCQNHP.GetComponent<Skybox>();
			Skybox component2 = DLJBEFQJPML.GetComponent<Skybox>();
			if (component && component.material)
			{
				component2.enabled = false;
				component2.material = component.material;
			}
			else
			{
				component2.enabled = false;
			}
		}
		DLJBEFQJPML.farClipPlane = IBLLKJCQNHP.farClipPlane;
		DLJBEFQJPML.nearClipPlane = IBLLKJCQNHP.nearClipPlane;
		DLJBEFQJPML.orthographic = IBLLKJCQNHP.orthographic;
		DLJBEFQJPML.fieldOfView = IBLLKJCQNHP.fieldOfView;
		DLJBEFQJPML.aspect = IBLLKJCQNHP.aspect;
		DLJBEFQJPML.orthographicSize = IBLLKJCQNHP.orthographicSize;
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00042788 File Offset: 0x00040988
	private void OnDisable()
	{
		if (this.LHLGQMLGCJG)
		{
			UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
			this.LHLGQMLGCJG = null;
		}
		if (this.HDIKQFMDFQJ)
		{
			UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
			this.HDIKQFMDFQJ = null;
		}
		foreach (KeyValuePair<Camera, Camera> keyValuePair in this.GQGPPLOPBDG)
		{
			UnityEngine.Object.DestroyImmediate(keyValuePair.Value.gameObject);
		}
		this.GQGPPLOPBDG.Clear();
		foreach (KeyValuePair<Camera, Camera> keyValuePair2 in this.OKODNGMFQIB)
		{
			UnityEngine.Object.DestroyImmediate(keyValuePair2.Value.gameObject);
		}
		this.OKODNGMFQIB.Clear();
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x000443F8 File Offset: 0x000425F8
	private void HDMNIKNDNGQ()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return;
		}
		Vector4 vector = sharedMaterial.GetVector("healer");
		float @float = sharedMaterial.GetFloat("1");
		Vector4 value = new Vector4(@float, @float, @float * 1049f, @float * 4f);
		double num = (double)Time.timeSinceLevelLoad / 1158.0;
		Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 1776.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 1249.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 369.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 1977.0));
		sharedMaterial.SetVector(",", value2);
		sharedMaterial.SetVector("1", value);
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00044514 File Offset: 0x00042714
	private void DIPEQCFCCCC(Camera IBLLKJCQNHP, Camera DLJBEFQJPML)
	{
		if (DLJBEFQJPML == null)
		{
			return;
		}
		DLJBEFQJPML.clearFlags = IBLLKJCQNHP.clearFlags;
		DLJBEFQJPML.backgroundColor = IBLLKJCQNHP.backgroundColor;
		if (IBLLKJCQNHP.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox component = IBLLKJCQNHP.GetComponent<Skybox>();
			Skybox component2 = DLJBEFQJPML.GetComponent<Skybox>();
			if (component && component.material)
			{
				component2.enabled = false;
				component2.material = component.material;
			}
			else
			{
				component2.enabled = false;
			}
		}
		DLJBEFQJPML.farClipPlane = IBLLKJCQNHP.farClipPlane;
		DLJBEFQJPML.nearClipPlane = IBLLKJCQNHP.nearClipPlane;
		DLJBEFQJPML.orthographic = IBLLKJCQNHP.orthographic;
		DLJBEFQJPML.fieldOfView = IBLLKJCQNHP.fieldOfView;
		DLJBEFQJPML.aspect = IBLLKJCQNHP.aspect;
		DLJBEFQJPML.orthographicSize = IBLLKJCQNHP.orthographicSize;
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00042D60 File Offset: 0x00040F60
	private Vector4 KBKJFNDCHIG(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x000445D4 File Offset: 0x000427D4
	private void CLHQMCOJHHE(Camera EBNOGGPBLNC, out Camera BCKOIGBNIPQ, out Camera GEKQNPJBJEI)
	{
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.PLMOGKHBQEQ();
		BCKOIGBNIPQ = null;
		GEKQNPJBJEI = null;
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Reflective)
		{
			if (!this.LHLGQMLGCJG || this.CNNBOPBDLQE != this.JMLPENNCCLP)
			{
				if (this.LHLGQMLGCJG)
				{
					UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
				}
				this.LHLGQMLGCJG = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 16);
				this.LHLGQMLGCJG.name = "__WaterReflection" + base.GetInstanceID();
				this.LHLGQMLGCJG.isPowerOfTwo = true;
				this.LHLGQMLGCJG.hideFlags = HideFlags.DontSave;
				this.CNNBOPBDLQE = this.JMLPENNCCLP;
			}
			this.GQGPPLOPBDG.TryGetValue(EBNOGGPBLNC, out BCKOIGBNIPQ);
			if (!BCKOIGBNIPQ)
			{
				GameObject gameObject = new GameObject(string.Concat(new object[]
				{
					"Water Refl Camera id",
					base.GetInstanceID(),
					" for ",
					EBNOGGPBLNC.GetInstanceID()
				}), new Type[]
				{
					typeof(Camera),
					typeof(Skybox)
				});
				BCKOIGBNIPQ = gameObject.GetComponent<Camera>();
				BCKOIGBNIPQ.enabled = false;
				BCKOIGBNIPQ.transform.position = base.transform.position;
				BCKOIGBNIPQ.transform.rotation = base.transform.rotation;
				BCKOIGBNIPQ.gameObject.AddComponent<FlareLayer>();
				gameObject.hideFlags = HideFlags.HideAndDontSave;
				this.GQGPPLOPBDG[EBNOGGPBLNC] = BCKOIGBNIPQ;
			}
		}
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Refractive)
		{
			if (!this.HDIKQFMDFQJ || this.CMKJLPNONPM != this.JMLPENNCCLP)
			{
				if (this.HDIKQFMDFQJ)
				{
					UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
				}
				this.HDIKQFMDFQJ = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 16);
				this.HDIKQFMDFQJ.name = "__WaterRefraction" + base.GetInstanceID();
				this.HDIKQFMDFQJ.isPowerOfTwo = true;
				this.HDIKQFMDFQJ.hideFlags = HideFlags.DontSave;
				this.CMKJLPNONPM = this.JMLPENNCCLP;
			}
			this.OKODNGMFQIB.TryGetValue(EBNOGGPBLNC, out GEKQNPJBJEI);
			if (!GEKQNPJBJEI)
			{
				GameObject gameObject2 = new GameObject(string.Concat(new object[]
				{
					"Water Refr Camera id",
					base.GetInstanceID(),
					" for ",
					EBNOGGPBLNC.GetInstanceID()
				}), new Type[]
				{
					typeof(Camera),
					typeof(Skybox)
				});
				GEKQNPJBJEI = gameObject2.GetComponent<Camera>();
				GEKQNPJBJEI.enabled = false;
				GEKQNPJBJEI.transform.position = base.transform.position;
				GEKQNPJBJEI.transform.rotation = base.transform.rotation;
				GEKQNPJBJEI.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = HideFlags.HideAndDontSave;
				this.OKODNGMFQIB[EBNOGGPBLNC] = GEKQNPJBJEI;
			}
		}
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00003E41 File Offset: 0x00002041
	private LBDMDNMJINK.MKJBFKGFBPF OPQPODNDOPQ()
	{
		if (this.NLLKOOEHOCE < this.EBIMEODKNMO)
		{
			return this.NLLKOOEHOCE;
		}
		return this.EBIMEODKNMO;
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x000448D0 File Offset: 0x00042AD0
	public void OCGLEQDQPIK()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (LBDMDNMJINK.QFPBHEIGQIK)
		{
			return;
		}
		LBDMDNMJINK.QFPBHEIGQIK = true;
		this.NLLKOOEHOCE = this.ELLKQHNEDPB();
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.MOLLIMJIIFB();
		Camera camera;
		Camera camera2;
		this.HHQECIKHKIJ(current, out camera, out camera2);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = 0;
		}
		this.EMMFQHQIBEQ(current, camera);
		this.MOHQIGHMDLI(current, camera2);
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			float w = -Vector3.Dot(up, position) - this.FONKIGGPJNQ;
			Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			LBDMDNMJINK.MLBGPCOHLME(ref zero, nioiglmodlj);
			Vector3 position2 = current.transform.position;
			Vector3 position3 = zero.MultiplyPoint(position2);
			camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
			Vector4 clipPlane = this.KBKJFNDCHIG(camera, position, up, 403f);
			camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
			camera.cullingMask = (-44 & this.QNOLOCMMMKM.value);
			camera.targetTexture = this.LHLGQMLGCJG;
			bool invertCulling;
			GL.invertCulling = !(invertCulling = GL.invertCulling);
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			camera.Render();
			camera.transform.position = position2;
			GL.invertCulling = invertCulling;
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("mega", this.LHLGQMLGCJG);
		}
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			camera2.worldToCameraMatrix = current.worldToCameraMatrix;
			Vector4 clipPlane2 = this.IEJPJEDBGON(camera2, position, up, 1737f);
			camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
			camera2.cullingMask = (49 & this.NCDOOJEBFPE.value);
			camera2.targetTexture = this.HDIKQFMDFQJ;
			camera2.transform.position = current.transform.position;
			camera2.transform.rotation = current.transform.rotation;
			camera2.Render();
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("|", this.HDIKQFMDFQJ);
		}
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
			{
				if (mkjbfkgfbpf == (LBDMDNMJINK.MKJBFKGFBPF)4)
				{
					Shader.DisableKeyword("!\r\n");
					Shader.DisableKeyword("door_3");
					Shader.EnableKeyword("_");
				}
			}
			else
			{
				Shader.DisableKeyword("_DetailScaleX");
				Shader.EnableKeyword("Shake");
				Shader.DisableKeyword("\\n");
			}
		}
		else
		{
			Shader.EnableKeyword(" (TextureClip)");
			Shader.DisableKeyword("[-]");
			Shader.DisableKeyword("_ColorMul");
		}
		LBDMDNMJINK.QFPBHEIGQIK = false;
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00003E41 File Offset: 0x00002041
	private LBDMDNMJINK.MKJBFKGFBPF NQJBLDIEDNH()
	{
		if (this.NLLKOOEHOCE < this.EBIMEODKNMO)
		{
			return this.NLLKOOEHOCE;
		}
		return this.EBIMEODKNMO;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00044BF0 File Offset: 0x00042DF0
	private void JBCLEJDIQIJ(Camera EBNOGGPBLNC, out Camera BCKOIGBNIPQ, out Camera GEKQNPJBJEI)
	{
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.MOLLIMJIIFB();
		BCKOIGBNIPQ = null;
		GEKQNPJBJEI = null;
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Reflective)
		{
			if (!this.LHLGQMLGCJG || this.CNNBOPBDLQE != this.JMLPENNCCLP)
			{
				if (this.LHLGQMLGCJG)
				{
					UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
				}
				this.LHLGQMLGCJG = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 105);
				this.LHLGQMLGCJG.name = "snorlax" + base.GetInstanceID();
				this.LHLGQMLGCJG.isPowerOfTwo = false;
				this.LHLGQMLGCJG.hideFlags = (HideFlags)83;
				this.CNNBOPBDLQE = this.JMLPENNCCLP;
			}
			this.GQGPPLOPBDG.TryGetValue(EBNOGGPBLNC, out BCKOIGBNIPQ);
			if (!BCKOIGBNIPQ)
			{
				object[] array = new object[5];
				array[1] = "castformsunny";
				array[0] = base.GetInstanceID();
				array[8] = "blacksludge";
				array[4] = EBNOGGPBLNC.GetInstanceID();
				string name = string.Concat(array);
				Type[] array2 = new Type[6];
				array2[1] = typeof(Camera);
				array2[0] = typeof(Skybox);
				GameObject gameObject = new GameObject(name, array2);
				BCKOIGBNIPQ = gameObject.GetComponent<Camera>();
				BCKOIGBNIPQ.enabled = false;
				BCKOIGBNIPQ.transform.position = base.transform.position;
				BCKOIGBNIPQ.transform.rotation = base.transform.rotation;
				BCKOIGBNIPQ.gameObject.AddComponent<FlareLayer>();
				gameObject.hideFlags = (HideFlags)114;
				this.GQGPPLOPBDG[EBNOGGPBLNC] = BCKOIGBNIPQ;
			}
		}
		if (mkjbfkgfbpf >= (LBDMDNMJINK.MKJBFKGFBPF)6)
		{
			if (!this.HDIKQFMDFQJ || this.CMKJLPNONPM != this.JMLPENNCCLP)
			{
				if (this.HDIKQFMDFQJ)
				{
					UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
				}
				this.HDIKQFMDFQJ = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 27);
				this.HDIKQFMDFQJ.name = "Goto" + base.GetInstanceID();
				this.HDIKQFMDFQJ.isPowerOfTwo = true;
				this.HDIKQFMDFQJ.hideFlags = (HideFlags)65;
				this.CMKJLPNONPM = this.JMLPENNCCLP;
			}
			this.OKODNGMFQIB.TryGetValue(EBNOGGPBLNC, out GEKQNPJBJEI);
			if (!GEKQNPJBJEI)
			{
				object[] array3 = new object[1];
				array3[0] = "Dig";
				array3[1] = base.GetInstanceID();
				array3[2] = "Boosts move power when the Pokémon moves last.";
				array3[5] = EBNOGGPBLNC.GetInstanceID();
				string name2 = string.Concat(array3);
				Type[] array4 = new Type[0];
				array4[1] = typeof(Camera);
				array4[1] = typeof(Skybox);
				GameObject gameObject2 = new GameObject(name2, array4);
				GEKQNPJBJEI = gameObject2.GetComponent<Camera>();
				GEKQNPJBJEI.enabled = true;
				GEKQNPJBJEI.transform.position = base.transform.position;
				GEKQNPJBJEI.transform.rotation = base.transform.rotation;
				GEKQNPJBJEI.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = (HideFlags)90;
				this.OKODNGMFQIB[EBNOGGPBLNC] = GEKQNPJBJEI;
			}
		}
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00044EEC File Offset: 0x000430EC
	private LBDMDNMJINK.MKJBFKGFBPF EMBEHBEQFNN()
	{
		if (!base.GetComponent<Renderer>())
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
		}
		string tag = sharedMaterial.GetTag("[-][/u]", false);
		if (tag == " started!\r\n")
		{
			return (LBDMDNMJINK.MKJBFKGFBPF)4;
		}
		if (tag == " shared its power with the target!\r\n")
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
		}
		return LBDMDNMJINK.MKJBFKGFBPF.Simple;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00044F4C File Offset: 0x0004314C
	private void HIMPKDOEEDP(Camera EBNOGGPBLNC, out Camera BCKOIGBNIPQ, out Camera GEKQNPJBJEI)
	{
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.JNQHKFKHHFD();
		BCKOIGBNIPQ = null;
		GEKQNPJBJEI = null;
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Reflective)
		{
			if (!this.LHLGQMLGCJG || this.CNNBOPBDLQE != this.JMLPENNCCLP)
			{
				if (this.LHLGQMLGCJG)
				{
					UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
				}
				this.LHLGQMLGCJG = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, -113);
				this.LHLGQMLGCJG.name = "HM" + base.GetInstanceID();
				this.LHLGQMLGCJG.isPowerOfTwo = false;
				this.LHLGQMLGCJG.hideFlags = (HideFlags)113;
				this.CNNBOPBDLQE = this.JMLPENNCCLP;
			}
			this.GQGPPLOPBDG.TryGetValue(EBNOGGPBLNC, out BCKOIGBNIPQ);
			if (!BCKOIGBNIPQ)
			{
				object[] array = new object[3];
				array[0] = "General";
				array[1] = base.GetInstanceID();
				array[5] = "[PD]";
				array[0] = EBNOGGPBLNC.GetInstanceID();
				string name = string.Concat(array);
				Type[] array2 = new Type[8];
				array2[0] = typeof(Camera);
				array2[0] = typeof(Skybox);
				GameObject gameObject = new GameObject(name, array2);
				BCKOIGBNIPQ = gameObject.GetComponent<Camera>();
				BCKOIGBNIPQ.enabled = true;
				BCKOIGBNIPQ.transform.position = base.transform.position;
				BCKOIGBNIPQ.transform.rotation = base.transform.rotation;
				BCKOIGBNIPQ.gameObject.AddComponent<FlareLayer>();
				gameObject.hideFlags = (HideFlags)126;
				this.GQGPPLOPBDG[EBNOGGPBLNC] = BCKOIGBNIPQ;
			}
		}
		if (mkjbfkgfbpf >= (LBDMDNMJINK.MKJBFKGFBPF)6)
		{
			if (!this.HDIKQFMDFQJ || this.CMKJLPNONPM != this.JMLPENNCCLP)
			{
				if (this.HDIKQFMDFQJ)
				{
					UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
				}
				this.HDIKQFMDFQJ = new RenderTexture(this.JMLPENNCCLP, this.JMLPENNCCLP, 61);
				this.HDIKQFMDFQJ.name = "Fen Badge" + base.GetInstanceID();
				this.HDIKQFMDFQJ.isPowerOfTwo = true;
				this.HDIKQFMDFQJ.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				this.CMKJLPNONPM = this.JMLPENNCCLP;
			}
			this.OKODNGMFQIB.TryGetValue(EBNOGGPBLNC, out GEKQNPJBJEI);
			if (!GEKQNPJBJEI)
			{
				object[] array3 = new object[7];
				array3[1] = ")";
				array3[1] = base.GetInstanceID();
				array3[7] = "1|";
				array3[8] = EBNOGGPBLNC.GetInstanceID();
				string name2 = string.Concat(array3);
				Type[] array4 = new Type[5];
				array4[0] = typeof(Camera);
				array4[1] = typeof(Skybox);
				GameObject gameObject2 = new GameObject(name2, array4);
				GEKQNPJBJEI = gameObject2.GetComponent<Camera>();
				GEKQNPJBJEI.enabled = true;
				GEKQNPJBJEI.transform.position = base.transform.position;
				GEKQNPJBJEI.transform.rotation = base.transform.rotation;
				GEKQNPJBJEI.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = HideFlags.NotEditable;
				this.OKODNGMFQIB[EBNOGGPBLNC] = GEKQNPJBJEI;
			}
		}
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00045248 File Offset: 0x00043448
	public void OMQOEFJHGHP()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (LBDMDNMJINK.QFPBHEIGQIK)
		{
			return;
		}
		LBDMDNMJINK.QFPBHEIGQIK = false;
		this.NLLKOOEHOCE = this.ENJPPHNKHOH();
		LBDMDNMJINK.MKJBFKGFBPF mkjbfkgfbpf = this.PLMOGKHBQEQ();
		Camera camera;
		Camera camera2;
		this.HIMPKDOEEDP(current, out camera, out camera2);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = 1;
		}
		this.EQPNDPGNCBB(current, camera);
		this.DIPEQCFCCCC(current, camera2);
		if (mkjbfkgfbpf >= LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			float w = -Vector3.Dot(up, position) - this.FONKIGGPJNQ;
			Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			LBDMDNMJINK.HPJEFFCPBQJ(ref zero, nioiglmodlj);
			Vector3 position2 = current.transform.position;
			Vector3 position3 = zero.MultiplyPoint(position2);
			camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
			Vector4 clipPlane = this.GDMJHENLGKH(camera, position, up, 1538f);
			camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
			camera.cullingMask = (4 & this.QNOLOCMMMKM.value);
			camera.targetTexture = this.LHLGQMLGCJG;
			bool invertCulling;
			GL.invertCulling = (invertCulling = GL.invertCulling);
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			camera.Render();
			camera.transform.position = position2;
			GL.invertCulling = invertCulling;
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("Purchase Costume", this.LHLGQMLGCJG);
		}
		if (mkjbfkgfbpf >= (LBDMDNMJINK.MKJBFKGFBPF)4)
		{
			camera2.worldToCameraMatrix = current.worldToCameraMatrix;
			Vector4 clipPlane2 = this.NLLQCPGQPLJ(camera2, position, up, 1095f);
			camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
			camera2.cullingMask = (38 & this.NCDOOJEBFPE.value);
			camera2.targetTexture = this.HDIKQFMDFQJ;
			camera2.transform.position = current.transform.position;
			camera2.transform.rotation = current.transform.rotation;
			camera2.Render();
			base.GetComponent<Renderer>().sharedMaterial.SetTexture("The mysterious strong winds have dissipated!", this.HDIKQFMDFQJ);
		}
		if (this.GNGEEFJNPGL)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Simple)
		{
			if (mkjbfkgfbpf != LBDMDNMJINK.MKJBFKGFBPF.Reflective)
			{
				if (mkjbfkgfbpf == LBDMDNMJINK.MKJBFKGFBPF.Reflective)
				{
					Shader.DisableKeyword("mistyterrain");
					Shader.DisableKeyword("[00AAFF]From:[-] ");
					Shader.EnableKeyword("'s ");
				}
			}
			else
			{
				Shader.DisableKeyword(" (ID:");
				Shader.EnableKeyword("Surge Surfer");
				Shader.DisableKeyword("[ATK]");
			}
		}
		else
		{
			Shader.EnableKeyword("[PG]");
			Shader.DisableKeyword("Heatproof");
			Shader.DisableKeyword("[-]\r\nPP ");
		}
		LBDMDNMJINK.QFPBHEIGQIK = false;
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00042788 File Offset: 0x00040988
	private void NFPQKFCHDGM()
	{
		if (this.LHLGQMLGCJG)
		{
			UnityEngine.Object.DestroyImmediate(this.LHLGQMLGCJG);
			this.LHLGQMLGCJG = null;
		}
		if (this.HDIKQFMDFQJ)
		{
			UnityEngine.Object.DestroyImmediate(this.HDIKQFMDFQJ);
			this.HDIKQFMDFQJ = null;
		}
		foreach (KeyValuePair<Camera, Camera> keyValuePair in this.GQGPPLOPBDG)
		{
			UnityEngine.Object.DestroyImmediate(keyValuePair.Value.gameObject);
		}
		this.GQGPPLOPBDG.Clear();
		foreach (KeyValuePair<Camera, Camera> keyValuePair2 in this.OKODNGMFQIB)
		{
			UnityEngine.Object.DestroyImmediate(keyValuePair2.Value.gameObject);
		}
		this.OKODNGMFQIB.Clear();
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00042D60 File Offset: 0x00040F60
	private Vector4 MLCPEMBGINL(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00045568 File Offset: 0x00043768
	private LBDMDNMJINK.MKJBFKGFBPF ENJPPHNKHOH()
	{
		if (!base.GetComponent<Renderer>())
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		string tag = sharedMaterial.GetTag("WATERMODE", false);
		if (tag == "Refractive")
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Refractive;
		}
		if (tag == "Reflective")
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
		}
		return LBDMDNMJINK.MKJBFKGFBPF.Simple;
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x000455C8 File Offset: 0x000437C8
	private void ELGDDBCPLFE(Camera IBLLKJCQNHP, Camera DLJBEFQJPML)
	{
		if (DLJBEFQJPML == null)
		{
			return;
		}
		DLJBEFQJPML.clearFlags = IBLLKJCQNHP.clearFlags;
		DLJBEFQJPML.backgroundColor = IBLLKJCQNHP.backgroundColor;
		if (IBLLKJCQNHP.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox component = IBLLKJCQNHP.GetComponent<Skybox>();
			Skybox component2 = DLJBEFQJPML.GetComponent<Skybox>();
			if (component && component.material)
			{
				component2.enabled = true;
				component2.material = component.material;
			}
			else
			{
				component2.enabled = true;
			}
		}
		DLJBEFQJPML.farClipPlane = IBLLKJCQNHP.farClipPlane;
		DLJBEFQJPML.nearClipPlane = IBLLKJCQNHP.nearClipPlane;
		DLJBEFQJPML.orthographic = IBLLKJCQNHP.orthographic;
		DLJBEFQJPML.fieldOfView = IBLLKJCQNHP.fieldOfView;
		DLJBEFQJPML.aspect = IBLLKJCQNHP.aspect;
		DLJBEFQJPML.orthographicSize = IBLLKJCQNHP.orthographicSize;
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00044514 File Offset: 0x00042714
	private void MOHQIGHMDLI(Camera IBLLKJCQNHP, Camera DLJBEFQJPML)
	{
		if (DLJBEFQJPML == null)
		{
			return;
		}
		DLJBEFQJPML.clearFlags = IBLLKJCQNHP.clearFlags;
		DLJBEFQJPML.backgroundColor = IBLLKJCQNHP.backgroundColor;
		if (IBLLKJCQNHP.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox component = IBLLKJCQNHP.GetComponent<Skybox>();
			Skybox component2 = DLJBEFQJPML.GetComponent<Skybox>();
			if (component && component.material)
			{
				component2.enabled = false;
				component2.material = component.material;
			}
			else
			{
				component2.enabled = false;
			}
		}
		DLJBEFQJPML.farClipPlane = IBLLKJCQNHP.farClipPlane;
		DLJBEFQJPML.nearClipPlane = IBLLKJCQNHP.nearClipPlane;
		DLJBEFQJPML.orthographic = IBLLKJCQNHP.orthographic;
		DLJBEFQJPML.fieldOfView = IBLLKJCQNHP.fieldOfView;
		DLJBEFQJPML.aspect = IBLLKJCQNHP.aspect;
		DLJBEFQJPML.orthographicSize = IBLLKJCQNHP.orthographicSize;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00045688 File Offset: 0x00043888
	private void QFFJMIOJENJ()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return;
		}
		Vector4 vector = sharedMaterial.GetVector("Assets/AssetBundles/MapAssets/Models/Materials/chip_mado.mat");
		float @float = sharedMaterial.GetFloat("Language");
		Vector4 value = new Vector4(@float, @float, @float * 595f, @float * 1583f);
		double num = (double)Time.timeSinceLevelLoad / 1539.0;
		Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 20.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 1491.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 1760.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 1442.0));
		sharedMaterial.SetVector("Player/Clothe", value2);
		sharedMaterial.SetVector("Run_White", value);
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00042D60 File Offset: 0x00040F60
	private Vector4 KCIJPGNGENK(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x000457A4 File Offset: 0x000439A4
	private void IBPJIOLMDLE()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return;
		}
		Vector4 vector = sharedMaterial.GetVector("Username");
		float @float = sharedMaterial.GetFloat("_Balance");
		Vector4 value = new Vector4(@float, @float, @float * 485f, @float * 1807f);
		double num = (double)Time.timeSinceLevelLoad / 287.0;
		Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 918.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 37.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 1302.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 703.0));
		sharedMaterial.SetVector("[-]!\r\n", value2);
		sharedMaterial.SetVector("M0", value);
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x000458C0 File Offset: 0x00043AC0
	private static void HPJEFFCPBQJ(ref Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1f - 2f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m01 = -2f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = -2f * NIOIGLMODLJ[0] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m03 = -2f * NIOIGLMODLJ[3] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = -2f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1f - 2f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = -2f * NIOIGLMODLJ[1] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m13 = -2f * NIOIGLMODLJ[3] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m20 = -2f * NIOIGLMODLJ[2] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = -2f * NIOIGLMODLJ[2] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m22 = 1f - 2f * NIOIGLMODLJ[2] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m23 = -2f * NIOIGLMODLJ[3] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m30 = 0f;
		IODFJKQOEMK.m31 = 0f;
		IODFJKQOEMK.m32 = 0f;
		IODFJKQOEMK.m33 = 1f;
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00045A68 File Offset: 0x00043C68
	private LBDMDNMJINK.MKJBFKGFBPF JQGHQLFHCHE()
	{
		if (!base.GetComponent<Renderer>())
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Reflective;
		}
		Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		string tag = sharedMaterial.GetTag(" started heating up its beak!\r\n", false);
		if (tag == " concentrated intensely!\r\n")
		{
			return (LBDMDNMJINK.MKJBFKGFBPF)7;
		}
		if (tag == "[-] threw an ")
		{
			return LBDMDNMJINK.MKJBFKGFBPF.Simple;
		}
		return LBDMDNMJINK.MKJBFKGFBPF.Simple;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00042D60 File Offset: 0x00040F60
	private Vector4 NLLQCPGQPLJ(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x04000086 RID: 134
	public LBDMDNMJINK.MKJBFKGFBPF EBIMEODKNMO = LBDMDNMJINK.MKJBFKGFBPF.Refractive;

	// Token: 0x04000087 RID: 135
	public bool GNGEEFJNPGL = true;

	// Token: 0x04000088 RID: 136
	public int JMLPENNCCLP = 256;

	// Token: 0x04000089 RID: 137
	public float FONKIGGPJNQ = 0.07f;

	// Token: 0x0400008A RID: 138
	public LayerMask QNOLOCMMMKM = -1;

	// Token: 0x0400008B RID: 139
	public LayerMask NCDOOJEBFPE = -1;

	// Token: 0x0400008C RID: 140
	private Dictionary<Camera, Camera> GQGPPLOPBDG = new Dictionary<Camera, Camera>();

	// Token: 0x0400008D RID: 141
	private Dictionary<Camera, Camera> OKODNGMFQIB = new Dictionary<Camera, Camera>();

	// Token: 0x0400008E RID: 142
	private RenderTexture LHLGQMLGCJG;

	// Token: 0x0400008F RID: 143
	private RenderTexture HDIKQFMDFQJ;

	// Token: 0x04000090 RID: 144
	private LBDMDNMJINK.MKJBFKGFBPF NLLKOOEHOCE = LBDMDNMJINK.MKJBFKGFBPF.Refractive;

	// Token: 0x04000091 RID: 145
	private int CNNBOPBDLQE;

	// Token: 0x04000092 RID: 146
	private int CMKJLPNONPM;

	// Token: 0x04000093 RID: 147
	private static bool QFPBHEIGQIK;

	// Token: 0x0200001A RID: 26
	public enum MKJBFKGFBPF
	{
		// Token: 0x04000095 RID: 149
		Simple,
		// Token: 0x04000096 RID: 150
		Reflective,
		// Token: 0x04000097 RID: 151
		Refractive
	}
}
