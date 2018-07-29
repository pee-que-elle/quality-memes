using System;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x020002CD RID: 717
public sealed class NHGDDFNJIPM : NHOOQNHPFOB<ScreenSpaceReflectionModel>
{
	// Token: 0x0600638B RID: 25483 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode BQDEFBEEJFF()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600638C RID: 25484 RVA: 0x00026D46 File Offset: 0x00024F46
	public bool HLNQKONHMND()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.MEPHDLOPGDJ() && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x17000375 RID: 885
	// (get) Token: 0x0600638D RID: 25485 RVA: 0x00026D73 File Offset: 0x00024F73
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.GKHCOPLEQKQ && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x0600638E RID: 25486 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode BOHOKLKPIEG()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0600638F RID: 25487 RVA: 0x0032AD20 File Offset: 0x00328F20
	public override void EIQKCDHPCKK(CommandBuffer KLIOPLGOLQC)
	{
		ScreenSpaceReflectionModel.Settings settings = base.FIFNHCKNDQE.settings;
		Camera lnckngkghln = this.BEHMQBIFCOJ.LNCKNGKGHLN;
		int num = (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 2 : 1;
		int num2 = this.BEHMQBIFCOJ.KJGMGPCEJJD / num;
		int num3 = this.BEHMQBIFCOJ.DFKQMMIQDOO / num;
		float num4 = (float)this.BEHMQBIFCOJ.KJGMGPCEJJD;
		float num5 = (float)this.BEHMQBIFCOJ.DFKQMMIQDOO;
		float num6 = num4 / 2f;
		float num7 = num5 / 2f;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Screen Space Reflection");
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.BHFNCBONLCM, settings.reflection.stepSize);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EMFGDLOQJNP, (settings.reflection.blendType != ScreenSpaceReflectionModel.CIOIMDOBMJQ.Additive) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MMGNKGCQQDE, (!this.FICKPOPJEJC) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.FOQBHBCOPQC, (!this.JOKLJDFHOQJ) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EQMCDCEPMEF, (!settings.reflection.reflectBackfaces) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MGNLDKOOHED, (!this.LPODBIHPJBQ) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.QIJBGPLHPOI, settings.reflection.iterationCount);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.PHHBQIGOGJF, 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.KDDDKJBIMLK, (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.DNBQKLEOOKQ, (!this.LHHFHKECCKB) ? 0 : 1);
		float value = num4 / (-2f * Mathf.Tan(lnckngkghln.fieldOfView / 180f * 3.14159274f * 0.5f));
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BMJPGIHEEHH, value);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FEEKHDIFQPG, settings.screenEdgeMask.intensity);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.PBIGEGKGBHD, settings.reflection.reflectionBlur);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NEPNGNHGQLI, settings.reflection.maxDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.QCHDBJDNHID, settings.intensity.fadeDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NQMKIEEDFPI, settings.reflection.widthModifier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FODBNLPJJQP, settings.intensity.reflectionMultiplier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BJFBEJLHCNQ, settings.intensity.fresnelFade);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BHFQOHDNIDO, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lnckngkghln.projectionMatrix;
		Vector4 value2 = new Vector4(-2f / (num4 * projectionMatrix[0]), -2f / (num5 * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
		Vector3 v = (!float.IsPositiveInfinity(lnckngkghln.farClipPlane)) ? new Vector3(lnckngkghln.nearClipPlane * lnckngkghln.farClipPlane, lnckngkghln.nearClipPlane - lnckngkghln.farClipPlane, lnckngkghln.farClipPlane) : new Vector3(lnckngkghln.nearClipPlane, -1f, 1f);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.ENMNICIOJCN, new Vector2((float)num2, (float)num3));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.OQFLHEMQCQM, new Vector2(num4, num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.NDDIKNGMDLE, new Vector2(1f / num4, 1f / num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.GMPHHFOGFPC, value2);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.HNKDKQELBMH, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 0f, 0f, num6));
		lhs.SetRow(1, new Vector4(0f, num7, 0f, num7));
		lhs.SetRow(2, new Vector4(0f, 0f, 1f, 0f));
		lhs.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.JIKDHOHOKKE, value3);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.CEOFQIOMNID, lnckngkghln.worldToCameraMatrix);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.MFJJOIKFPLO, lnckngkghln.worldToCameraMatrix.inverse);
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.JCHDOOOJKIC) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGBHalf;
		int ledmbgmihgm = NHGDDFNJIPM.ODHEEOJLQIG.LEDMBGMIHGM;
		int hegiehnlhnm = NHGDDFNJIPM.ODHEEOJLQIG.HEGIEHNLHNM;
		int ooigqhgnfqj = NHGDDFNJIPM.ODHEEOJLQIG.OOIGQHGNFQJ;
		int nnkdjelbfod = NHGDDFNJIPM.ODHEEOJLQIG.NNKDJELBFOD;
		int mcknijiejnh = NHGDDFNJIPM.ODHEEOJLQIG.MCKNIJIEJNH;
		int lkpqcgkqopq = NHGDDFNJIPM.ODHEEOJLQIG.LKPQCGKQOPQ;
		KLIOPLGOLQC.GetTemporaryRT(ledmbgmihgm, -1, -1, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.GetTemporaryRT(hegiehnlhnm, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 5; i++)
		{
			KLIOPLGOLQC.GetTemporaryRT(this.COLJNDFIQKO[i], num2 >> i, num3 >> i, 0, FilterMode.Bilinear, format);
		}
		KLIOPLGOLQC.GetTemporaryRT(nnkdjelbfod, num2, num3, 0, (!this.FICKPOPJEJC) ? FilterMode.Bilinear : FilterMode.Point, format);
		KLIOPLGOLQC.GetTemporaryRT(mcknijiejnh, num2, num3, 0, FilterMode.Point, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, ledmbgmihgm, material, 6);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, hegiehnlhnm, material, 0);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, nnkdjelbfod, material, 5);
		KLIOPLGOLQC.Blit(nnkdjelbfod, this.COLJNDFIQKO[0], material, 8);
		for (int j = 1; j < 5; j++)
		{
			int nameID = this.COLJNDFIQKO[j - 1];
			int num8 = j;
			KLIOPLGOLQC.GetTemporaryRT(ooigqhgnfqj, num2 >> num8, num3 >> num8, 0, FilterMode.Bilinear, format);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(1f, 0f, 0f, 0f));
			KLIOPLGOLQC.SetGlobalFloat(NHGDDFNJIPM.ODHEEOJLQIG.QKPFGBPFEEP, (float)j - 1f);
			KLIOPLGOLQC.Blit(nameID, ooigqhgnfqj, material, 2);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(0f, 1f, 0f, 0f));
			nameID = this.COLJNDFIQKO[j];
			KLIOPLGOLQC.Blit(ooigqhgnfqj, nameID, material, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(ooigqhgnfqj);
		}
		KLIOPLGOLQC.Blit(this.COLJNDFIQKO[0], mcknijiejnh, material, 3);
		KLIOPLGOLQC.GetTemporaryRT(lkpqcgkqopq, lnckngkghln.pixelWidth, lnckngkghln.pixelHeight, 0, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, lkpqcgkqopq, material, 1);
		KLIOPLGOLQC.Blit(lkpqcgkqopq, BuiltinRenderTextureType.CameraTarget);
		KLIOPLGOLQC.ReleaseTemporaryRT(lkpqcgkqopq);
	}

	// Token: 0x06006390 RID: 25488 RVA: 0x00026DA0 File Offset: 0x00024FA0
	public bool EPEEBMIMHDB()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.GNEOKCIFKBP() && this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006391 RID: 25489 RVA: 0x0032B3F0 File Offset: 0x003295F0
	public void HJCCEHMKHQC()
	{
		this.COLJNDFIQKO[0] = Shader.PropertyToID("Sometimes heals an ally's status condition.");
		this.COLJNDFIQKO[0] = Shader.PropertyToID("skydrop");
		this.COLJNDFIQKO[6] = Shader.PropertyToID("burn");
		this.COLJNDFIQKO[7] = Shader.PropertyToID("Ambient Occlusion");
		this.COLJNDFIQKO[6] = Shader.PropertyToID("-");
	}

	// Token: 0x06006392 RID: 25490 RVA: 0x0032B458 File Offset: 0x00329658
	public void EKDBCODMCOL(CommandBuffer KLIOPLGOLQC)
	{
		ScreenSpaceReflectionModel.Settings settings = base.FIFNHCKNDQE.GQBFLONJOEC();
		Camera lnckngkghln = this.BEHMQBIFCOJ.LNCKNGKGHLN;
		int num = (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 3 : 1;
		int num2 = this.BEHMQBIFCOJ.CQNLNDBFFFP() / num;
		int num3 = this.BEHMQBIFCOJ.JHHQQQGMQBM() / num;
		float num4 = (float)this.BEHMQBIFCOJ.CHODJCGKMOK();
		float num5 = (float)this.BEHMQBIFCOJ.DFKQMMIQDOO;
		float num6 = num4 / 1213f;
		float num7 = num5 / 1558f;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("_TraceBehindObjects");
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.BHFNCBONLCM, settings.reflection.stepSize);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EMFGDLOQJNP, (settings.reflection.blendType != ScreenSpaceReflectionModel.CIOIMDOBMJQ.Additive) ? 0 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MMGNKGCQQDE, (!this.FICKPOPJEJC) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.FOQBHBCOPQC, (!this.JOKLJDFHOQJ) ? 0 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EQMCDCEPMEF, (!settings.reflection.reflectBackfaces) ? 0 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MGNLDKOOHED, (!this.LPODBIHPJBQ) ? 1 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.QIJBGPLHPOI, settings.reflection.iterationCount);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.PHHBQIGOGJF, 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.KDDDKJBIMLK, (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 1 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.DNBQKLEOOKQ, (!this.LHHFHKECCKB) ? 0 : 1);
		float value = num4 / (41f * Mathf.Tan(lnckngkghln.fieldOfView / 957f * 557f * 1097f));
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BMJPGIHEEHH, value);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FEEKHDIFQPG, settings.screenEdgeMask.intensity);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.PBIGEGKGBHD, settings.reflection.reflectionBlur);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NEPNGNHGQLI, settings.reflection.maxDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.QCHDBJDNHID, settings.intensity.fadeDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NQMKIEEDFPI, settings.reflection.widthModifier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FODBNLPJJQP, settings.intensity.reflectionMultiplier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BJFBEJLHCNQ, settings.intensity.fresnelFade);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BHFQOHDNIDO, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lnckngkghln.projectionMatrix;
		Vector4 value2 = new Vector4(57f / (num4 * projectionMatrix[0]), 1551f / (num5 * projectionMatrix[4]), (1657f - projectionMatrix[4]) / projectionMatrix[0], (755f + projectionMatrix[4]) / projectionMatrix[8]);
		Vector3 v = (!float.IsPositiveInfinity(lnckngkghln.farClipPlane)) ? new Vector3(lnckngkghln.nearClipPlane * lnckngkghln.farClipPlane, lnckngkghln.nearClipPlane - lnckngkghln.farClipPlane, lnckngkghln.farClipPlane) : new Vector3(lnckngkghln.nearClipPlane, 661f, 1610f);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.ENMNICIOJCN, new Vector2((float)num2, (float)num3));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.OQFLHEMQCQM, new Vector2(num4, num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.NDDIKNGMDLE, new Vector2(909f / num4, 1488f / num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.GMPHHFOGFPC, value2);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.HNKDKQELBMH, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 1360f, 1136f, num6));
		lhs.SetRow(1, new Vector4(1281f, num7, 679f, num7));
		lhs.SetRow(2, new Vector4(252f, 920f, 1309f, 467f));
		lhs.SetRow(6, new Vector4(1967f, 1684f, 1785f, 1809f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.JIKDHOHOKKE, value3);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.CEOFQIOMNID, lnckngkghln.worldToCameraMatrix);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.MFJJOIKFPLO, lnckngkghln.worldToCameraMatrix.inverse);
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.CGKJPFHPGBN()) ? RenderTextureFormat.Depth : RenderTextureFormat.RGB565;
		int ledmbgmihgm = NHGDDFNJIPM.ODHEEOJLQIG.LEDMBGMIHGM;
		int hegiehnlhnm = NHGDDFNJIPM.ODHEEOJLQIG.HEGIEHNLHNM;
		int ooigqhgnfqj = NHGDDFNJIPM.ODHEEOJLQIG.OOIGQHGNFQJ;
		int nnkdjelbfod = NHGDDFNJIPM.ODHEEOJLQIG.NNKDJELBFOD;
		int mcknijiejnh = NHGDDFNJIPM.ODHEEOJLQIG.MCKNIJIEJNH;
		int lkpqcgkqopq = NHGDDFNJIPM.ODHEEOJLQIG.LKPQCGKQOPQ;
		KLIOPLGOLQC.GetTemporaryRT(ledmbgmihgm, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.GetTemporaryRT(hegiehnlhnm, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Linear);
		for (int i = 1; i < 5; i++)
		{
			KLIOPLGOLQC.GetTemporaryRT(this.COLJNDFIQKO[i], num2 >> (i & 114), num3 >> (i & 19), 0, FilterMode.Bilinear, format);
		}
		KLIOPLGOLQC.GetTemporaryRT(nnkdjelbfod, num2, num3, 1, (!this.FICKPOPJEJC) ? FilterMode.Bilinear : FilterMode.Bilinear, format);
		KLIOPLGOLQC.GetTemporaryRT(mcknijiejnh, num2, num3, 0, FilterMode.Point, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ledmbgmihgm, material, 8);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, hegiehnlhnm, material, 1);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.None, nnkdjelbfod, material, 1);
		KLIOPLGOLQC.Blit(nnkdjelbfod, this.COLJNDFIQKO[0], material, 0);
		for (int j = 0; j < 0; j += 0)
		{
			int nameID = this.COLJNDFIQKO[j - 1];
			int num8 = j;
			KLIOPLGOLQC.GetTemporaryRT(ooigqhgnfqj, num2 >> (num8 & -4), num3 >> (num8 & 35), 0, FilterMode.Point, format);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(953f, 449f, 1642f, 1953f));
			KLIOPLGOLQC.SetGlobalFloat(NHGDDFNJIPM.ODHEEOJLQIG.QKPFGBPFEEP, (float)j - 707f);
			KLIOPLGOLQC.Blit(nameID, ooigqhgnfqj, material, 6);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(1914f, 172f, 801f, 752f));
			nameID = this.COLJNDFIQKO[j];
			KLIOPLGOLQC.Blit(ooigqhgnfqj, nameID, material, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(ooigqhgnfqj);
		}
		KLIOPLGOLQC.Blit(this.COLJNDFIQKO[1], mcknijiejnh, material, 1);
		KLIOPLGOLQC.GetTemporaryRT(lkpqcgkqopq, lnckngkghln.pixelWidth, lnckngkghln.pixelHeight, 0, FilterMode.Point, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.None, lkpqcgkqopq, material, 0);
		KLIOPLGOLQC.Blit(lkpqcgkqopq, BuiltinRenderTextureType.Depth);
		KLIOPLGOLQC.ReleaseTemporaryRT(lkpqcgkqopq);
	}

	// Token: 0x06006393 RID: 25491 RVA: 0x00026DCD File Offset: 0x00024FCD
	public CameraEvent PJDGCFOQOOE()
	{
		return (CameraEvent)(-33);
	}

	// Token: 0x06006394 RID: 25492 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode HEOJHFKPGDH()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006395 RID: 25493 RVA: 0x0000B03A File Offset: 0x0000923A
	public override DepthTextureMode FDQNPDGFNHH()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06006396 RID: 25494 RVA: 0x00026DD1 File Offset: 0x00024FD1
	public CameraEvent HNJMEINLIMK()
	{
		return (CameraEvent)(-25);
	}

	// Token: 0x06006397 RID: 25495 RVA: 0x00026DD5 File Offset: 0x00024FD5
	public CameraEvent KODMLBKPPBD()
	{
		return (CameraEvent)(-55);
	}

	// Token: 0x06006398 RID: 25496 RVA: 0x00026DD9 File Offset: 0x00024FD9
	public string KIBNCJKCOPF()
	{
		return "_EmissionColor";
	}

	// Token: 0x06006399 RID: 25497 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode KFIMMEHOQIC()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600639A RID: 25498 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode PCHMOJGLMQN()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0600639B RID: 25499 RVA: 0x000267AA File Offset: 0x000249AA
	public CameraEvent BBHKCKJIKGK()
	{
		return (CameraEvent)(-52);
	}

	// Token: 0x0600639C RID: 25500 RVA: 0x0032BB28 File Offset: 0x00329D28
	public override void MNIFEBDOGKD()
	{
		this.COLJNDFIQKO[0] = Shader.PropertyToID("_ReflectionTexture0");
		this.COLJNDFIQKO[1] = Shader.PropertyToID("_ReflectionTexture1");
		this.COLJNDFIQKO[2] = Shader.PropertyToID("_ReflectionTexture2");
		this.COLJNDFIQKO[3] = Shader.PropertyToID("_ReflectionTexture3");
		this.COLJNDFIQKO[4] = Shader.PropertyToID("_ReflectionTexture4");
	}

	// Token: 0x0600639D RID: 25501 RVA: 0x0032BB90 File Offset: 0x00329D90
	public void CGIQQJOJDNQ()
	{
		this.COLJNDFIQKO[1] = Shader.PropertyToID("Chat Input");
		this.COLJNDFIQKO[0] = Shader.PropertyToID("Your account is already logged in..");
		this.COLJNDFIQKO[1] = Shader.PropertyToID("Assets/AssetBundles/MapAssets2/Models/JohtoHouse 1.fbm/Materials/com_chip_mado1.mat");
		this.COLJNDFIQKO[7] = Shader.PropertyToID("charge");
		this.COLJNDFIQKO[0] = Shader.PropertyToID("Camera Window");
	}

	// Token: 0x0600639E RID: 25502 RVA: 0x00026DE0 File Offset: 0x00024FE0
	public string DDPMKPODBKK()
	{
		return " got over its infatuation.\r\n";
	}

	// Token: 0x0600639F RID: 25503 RVA: 0x00026DE7 File Offset: 0x00024FE7
	public string HPMKCBQDMKG()
	{
		return "Pokemon have been automaticly centered!\r\n";
	}

	// Token: 0x060063A0 RID: 25504 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode HEKPQBOGQPB()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060063A1 RID: 25505 RVA: 0x00026DEE File Offset: 0x00024FEE
	public string FJHEKJPPHEP()
	{
		return "'s can't use [ffff00]";
	}

	// Token: 0x060063A2 RID: 25506 RVA: 0x00026DF5 File Offset: 0x00024FF5
	public CameraEvent MQKHFPNBFGB()
	{
		return (CameraEvent)(-54);
	}

	// Token: 0x060063A3 RID: 25507 RVA: 0x0032BBF8 File Offset: 0x00329DF8
	public void FKLMJCEJGND(CommandBuffer KLIOPLGOLQC)
	{
		ScreenSpaceReflectionModel.Settings settings = base.FIFNHCKNDQE.EOFMNIJDIGD();
		Camera lnckngkghln = this.BEHMQBIFCOJ.LNCKNGKGHLN;
		int num = (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 7 : 1;
		int num2 = this.BEHMQBIFCOJ.KJGMGPCEJJD / num;
		int num3 = this.BEHMQBIFCOJ.ONCCDMLHNQL() / num;
		float num4 = (float)this.BEHMQBIFCOJ.CQNLNDBFFFP();
		float num5 = (float)this.BEHMQBIFCOJ.DFKQMMIQDOO;
		float num6 = num4 / 189f;
		float num7 = num5 / 1548f;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MLLNLFQCMKQ("Max:");
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.BHFNCBONLCM, settings.reflection.stepSize);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EMFGDLOQJNP, (settings.reflection.blendType != ScreenSpaceReflectionModel.CIOIMDOBMJQ.Additive) ? 1 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MMGNKGCQQDE, (!this.FICKPOPJEJC) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.FOQBHBCOPQC, (!this.JOKLJDFHOQJ) ? 1 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EQMCDCEPMEF, (!settings.reflection.reflectBackfaces) ? 1 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MGNLDKOOHED, (!this.LPODBIHPJBQ) ? 1 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.QIJBGPLHPOI, settings.reflection.iterationCount);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.PHHBQIGOGJF, 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.KDDDKJBIMLK, (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 1 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.DNBQKLEOOKQ, (!this.LHHFHKECCKB) ? 0 : 0);
		float value = num4 / (867f * Mathf.Tan(lnckngkghln.fieldOfView / 1973f * 1307f * 275f));
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BMJPGIHEEHH, value);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FEEKHDIFQPG, settings.screenEdgeMask.intensity);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.PBIGEGKGBHD, settings.reflection.reflectionBlur);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NEPNGNHGQLI, settings.reflection.maxDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.QCHDBJDNHID, settings.intensity.fadeDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NQMKIEEDFPI, settings.reflection.widthModifier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FODBNLPJJQP, settings.intensity.reflectionMultiplier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BJFBEJLHCNQ, settings.intensity.fresnelFade);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BHFQOHDNIDO, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lnckngkghln.projectionMatrix;
		Vector4 value2 = new Vector4(797f / (num4 * projectionMatrix[1]), 450f / (num5 * projectionMatrix[8]), (683f - projectionMatrix[0]) / projectionMatrix[1], (257f + projectionMatrix[1]) / projectionMatrix[0]);
		Vector3 v = (!float.IsPositiveInfinity(lnckngkghln.farClipPlane)) ? new Vector3(lnckngkghln.nearClipPlane * lnckngkghln.farClipPlane, lnckngkghln.nearClipPlane - lnckngkghln.farClipPlane, lnckngkghln.farClipPlane) : new Vector3(lnckngkghln.nearClipPlane, 1624f, 1919f);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.ENMNICIOJCN, new Vector2((float)num2, (float)num3));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.OQFLHEMQCQM, new Vector2(num4, num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.NDDIKNGMDLE, new Vector2(898f / num4, 1544f / num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.GMPHHFOGFPC, value2);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.HNKDKQELBMH, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 933f, 1001f, num6));
		lhs.SetRow(0, new Vector4(515f, num7, 1047f, num7));
		lhs.SetRow(1, new Vector4(300f, 1507f, 1250f, 629f));
		lhs.SetRow(6, new Vector4(960f, 1351f, 1869f, 1560f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.JIKDHOHOKKE, value3);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.CEOFQIOMNID, lnckngkghln.worldToCameraMatrix);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.MFJJOIKFPLO, lnckngkghln.worldToCameraMatrix.inverse);
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.EOLMLQPKBKP()) ? RenderTextureFormat.Depth : RenderTextureFormat.ARGB4444;
		int ledmbgmihgm = NHGDDFNJIPM.ODHEEOJLQIG.LEDMBGMIHGM;
		int hegiehnlhnm = NHGDDFNJIPM.ODHEEOJLQIG.HEGIEHNLHNM;
		int ooigqhgnfqj = NHGDDFNJIPM.ODHEEOJLQIG.OOIGQHGNFQJ;
		int nnkdjelbfod = NHGDDFNJIPM.ODHEEOJLQIG.NNKDJELBFOD;
		int mcknijiejnh = NHGDDFNJIPM.ODHEEOJLQIG.MCKNIJIEJNH;
		int lkpqcgkqopq = NHGDDFNJIPM.ODHEEOJLQIG.LKPQCGKQOPQ;
		KLIOPLGOLQC.GetTemporaryRT(ledmbgmihgm, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.GetTemporaryRT(hegiehnlhnm, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
		for (int i = 1; i < 2; i++)
		{
			KLIOPLGOLQC.GetTemporaryRT(this.COLJNDFIQKO[i], num2 >> (i & 24), num3 >> (i & 114), 1, FilterMode.Bilinear, format);
		}
		KLIOPLGOLQC.GetTemporaryRT(nnkdjelbfod, num2, num3, 0, (!this.FICKPOPJEJC) ? FilterMode.Bilinear : FilterMode.Bilinear, format);
		KLIOPLGOLQC.GetTemporaryRT(mcknijiejnh, num2, num3, 1, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit((BuiltinRenderTextureType)6, ledmbgmihgm, material, 1);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassLight, hegiehnlhnm, material, 0);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.None, nnkdjelbfod, material, 5);
		KLIOPLGOLQC.Blit(nnkdjelbfod, this.COLJNDFIQKO[1], material, 5);
		for (int j = 1; j < 0; j += 0)
		{
			int nameID = this.COLJNDFIQKO[j - 0];
			int num8 = j;
			KLIOPLGOLQC.GetTemporaryRT(ooigqhgnfqj, num2 >> (num8 & -79), num3 >> (num8 & -43), 1, FilterMode.Bilinear, format);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(1037f, 1625f, 1209f, 157f));
			KLIOPLGOLQC.SetGlobalFloat(NHGDDFNJIPM.ODHEEOJLQIG.QKPFGBPFEEP, (float)j - 1357f);
			KLIOPLGOLQC.Blit(nameID, ooigqhgnfqj, material, 6);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(389f, 1905f, 1970f, 1150f));
			nameID = this.COLJNDFIQKO[j];
			KLIOPLGOLQC.Blit(ooigqhgnfqj, nameID, material, 1);
			KLIOPLGOLQC.ReleaseTemporaryRT(ooigqhgnfqj);
		}
		KLIOPLGOLQC.Blit(this.COLJNDFIQKO[0], mcknijiejnh, material, 3);
		KLIOPLGOLQC.GetTemporaryRT(lkpqcgkqopq, lnckngkghln.pixelWidth, lnckngkghln.pixelHeight, 0, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.None, lkpqcgkqopq, material, 0);
		KLIOPLGOLQC.Blit(lkpqcgkqopq, BuiltinRenderTextureType.ResolvedDepth);
		KLIOPLGOLQC.ReleaseTemporaryRT(lkpqcgkqopq);
	}

	// Token: 0x060063A4 RID: 25508 RVA: 0x00026DF9 File Offset: 0x00024FF9
	public CameraEvent DGNGCJCLMJL()
	{
		return (CameraEvent)(-75);
	}

	// Token: 0x060063A6 RID: 25510 RVA: 0x0032C2C8 File Offset: 0x0032A4C8
	public void JDGBGCHLNIC()
	{
		this.COLJNDFIQKO[1] = Shader.PropertyToID("aegislash");
		this.COLJNDFIQKO[0] = Shader.PropertyToID("Blank");
		this.COLJNDFIQKO[6] = Shader.PropertyToID("Poison Point");
		this.COLJNDFIQKO[1] = Shader.PropertyToID("BuffIcon_EncounterRateIncrease2");
		this.COLJNDFIQKO[0] = Shader.PropertyToID("H");
	}

	// Token: 0x060063A7 RID: 25511 RVA: 0x00026E1F File Offset: 0x0002501F
	public string PDPILOMBGMM()
	{
		return "b";
	}

	// Token: 0x060063A8 RID: 25512 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode IGILFNHCPJE()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060063A9 RID: 25513 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode CDOLEKJNGQO()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060063AA RID: 25514 RVA: 0x00026E26 File Offset: 0x00025026
	public string POPOJMOJHKE()
	{
		return "Powers up each Pokémon's Fairy-type moves.";
	}

	// Token: 0x060063AB RID: 25515 RVA: 0x0032C330 File Offset: 0x0032A530
	public void HGPMPIPMCBQ(CommandBuffer KLIOPLGOLQC)
	{
		ScreenSpaceReflectionModel.Settings settings = base.FIFNHCKNDQE.GQBFLONJOEC();
		Camera lnckngkghln = this.BEHMQBIFCOJ.LNCKNGKGHLN;
		int num = (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 5 : 1;
		int num2 = this.BEHMQBIFCOJ.KJGMGPCEJJD / num;
		int num3 = this.BEHMQBIFCOJ.JKGBHEHKBPC() / num;
		float num4 = (float)this.BEHMQBIFCOJ.KJGMGPCEJJD;
		float num5 = (float)this.BEHMQBIFCOJ.JHHQQQGMQBM();
		float num6 = num4 / 1884f;
		float num7 = num5 / 1038f;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DNKGKNNMFBC("Take 001");
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.BHFNCBONLCM, settings.reflection.stepSize);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EMFGDLOQJNP, (settings.reflection.blendType != ScreenSpaceReflectionModel.CIOIMDOBMJQ.PhysicallyBased) ? 0 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MMGNKGCQQDE, (!this.FICKPOPJEJC) ? 1 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.FOQBHBCOPQC, (!this.JOKLJDFHOQJ) ? 0 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EQMCDCEPMEF, (!settings.reflection.reflectBackfaces) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MGNLDKOOHED, (!this.LPODBIHPJBQ) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.QIJBGPLHPOI, settings.reflection.iterationCount);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.PHHBQIGOGJF, 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.KDDDKJBIMLK, (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 1 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.DNBQKLEOOKQ, (!this.LHHFHKECCKB) ? 0 : 0);
		float value = num4 / (463f * Mathf.Tan(lnckngkghln.fieldOfView / 552f * 323f * 395f));
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BMJPGIHEEHH, value);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FEEKHDIFQPG, settings.screenEdgeMask.intensity);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.PBIGEGKGBHD, settings.reflection.reflectionBlur);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NEPNGNHGQLI, settings.reflection.maxDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.QCHDBJDNHID, settings.intensity.fadeDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NQMKIEEDFPI, settings.reflection.widthModifier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FODBNLPJJQP, settings.intensity.reflectionMultiplier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BJFBEJLHCNQ, settings.intensity.fresnelFade);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BHFQOHDNIDO, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lnckngkghln.projectionMatrix;
		Vector4 value2 = new Vector4(950f / (num4 * projectionMatrix[1]), 654f / (num5 * projectionMatrix[7]), (118f - projectionMatrix[3]) / projectionMatrix[0], (1726f + projectionMatrix[7]) / projectionMatrix[5]);
		Vector3 v = (!float.IsPositiveInfinity(lnckngkghln.farClipPlane)) ? new Vector3(lnckngkghln.nearClipPlane * lnckngkghln.farClipPlane, lnckngkghln.nearClipPlane - lnckngkghln.farClipPlane, lnckngkghln.farClipPlane) : new Vector3(lnckngkghln.nearClipPlane, 1795f, 1268f);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.ENMNICIOJCN, new Vector2((float)num2, (float)num3));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.OQFLHEMQCQM, new Vector2(num4, num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.NDDIKNGMDLE, new Vector2(1989f / num4, 1707f / num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.GMPHHFOGFPC, value2);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.HNKDKQELBMH, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 1848f, 284f, num6));
		lhs.SetRow(1, new Vector4(841f, num7, 1752f, num7));
		lhs.SetRow(5, new Vector4(1904f, 1904f, 202f, 1959f));
		lhs.SetRow(5, new Vector4(1717f, 1283f, 123f, 830f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.JIKDHOHOKKE, value3);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.CEOFQIOMNID, lnckngkghln.worldToCameraMatrix);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.MFJJOIKFPLO, lnckngkghln.worldToCameraMatrix.inverse);
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.NJKQFCKNNLM()) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.RGB565;
		int ledmbgmihgm = NHGDDFNJIPM.ODHEEOJLQIG.LEDMBGMIHGM;
		int hegiehnlhnm = NHGDDFNJIPM.ODHEEOJLQIG.HEGIEHNLHNM;
		int ooigqhgnfqj = NHGDDFNJIPM.ODHEEOJLQIG.OOIGQHGNFQJ;
		int nnkdjelbfod = NHGDDFNJIPM.ODHEEOJLQIG.NNKDJELBFOD;
		int mcknijiejnh = NHGDDFNJIPM.ODHEEOJLQIG.MCKNIJIEJNH;
		int lkpqcgkqopq = NHGDDFNJIPM.ODHEEOJLQIG.LKPQCGKQOPQ;
		KLIOPLGOLQC.GetTemporaryRT(ledmbgmihgm, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.GetTemporaryRT(hegiehnlhnm, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
		for (int i = 0; i < 2; i++)
		{
			KLIOPLGOLQC.GetTemporaryRT(this.COLJNDFIQKO[i], num2 >> (i & -7), num3 >> (i & -119), 1, FilterMode.Bilinear, format);
		}
		KLIOPLGOLQC.GetTemporaryRT(nnkdjelbfod, num2, num3, 1, (!this.FICKPOPJEJC) ? FilterMode.Point : FilterMode.Point, format);
		KLIOPLGOLQC.GetTemporaryRT(mcknijiejnh, num2, num3, 0, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ledmbgmihgm, material, 2);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.ResolvedDepth, hegiehnlhnm, material, 1);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassLight, nnkdjelbfod, material, 2);
		KLIOPLGOLQC.Blit(nnkdjelbfod, this.COLJNDFIQKO[1], material, 4);
		for (int j = 1; j < 2; j += 0)
		{
			int nameID = this.COLJNDFIQKO[j - 0];
			int num8 = j;
			KLIOPLGOLQC.GetTemporaryRT(ooigqhgnfqj, num2 >> (num8 & 77), num3 >> (num8 & -26), 0, FilterMode.Bilinear, format);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(1707f, 1346f, 1836f, 543f));
			KLIOPLGOLQC.SetGlobalFloat(NHGDDFNJIPM.ODHEEOJLQIG.QKPFGBPFEEP, (float)j - 5f);
			KLIOPLGOLQC.Blit(nameID, ooigqhgnfqj, material, 5);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(589f, 1876f, 1497f, 304f));
			nameID = this.COLJNDFIQKO[j];
			KLIOPLGOLQC.Blit(ooigqhgnfqj, nameID, material, 8);
			KLIOPLGOLQC.ReleaseTemporaryRT(ooigqhgnfqj);
		}
		KLIOPLGOLQC.Blit(this.COLJNDFIQKO[0], mcknijiejnh, material, 3);
		KLIOPLGOLQC.GetTemporaryRT(lkpqcgkqopq, lnckngkghln.pixelWidth, lnckngkghln.pixelHeight, 0, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit((BuiltinRenderTextureType)6, lkpqcgkqopq, material, 0);
		KLIOPLGOLQC.Blit(lkpqcgkqopq, BuiltinRenderTextureType.PrepassNormalsSpec);
		KLIOPLGOLQC.ReleaseTemporaryRT(lkpqcgkqopq);
	}

	// Token: 0x060063AC RID: 25516 RVA: 0x0032CA00 File Offset: 0x0032AC00
	public void MGDHHCMONLK(CommandBuffer KLIOPLGOLQC)
	{
		ScreenSpaceReflectionModel.Settings settings = base.FIFNHCKNDQE.EFKIKEPOEGP();
		Camera lnckngkghln = this.BEHMQBIFCOJ.LNCKNGKGHLN;
		int num = (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 3 : 0;
		int num2 = this.BEHMQBIFCOJ.CHODJCGKMOK() / num;
		int num3 = this.BEHMQBIFCOJ.KPFJEIKPCBG() / num;
		float num4 = (float)this.BEHMQBIFCOJ.CHODJCGKMOK();
		float num5 = (float)this.BEHMQBIFCOJ.JKGBHEHKBPC();
		float num6 = num4 / 923f;
		float num7 = num5 / 1872f;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PIHPPJNJDQC("UNITY_COLORSPACE_GAMMA");
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.BHFNCBONLCM, settings.reflection.stepSize);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EMFGDLOQJNP, (settings.reflection.blendType != ScreenSpaceReflectionModel.CIOIMDOBMJQ.PhysicallyBased) ? 0 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MMGNKGCQQDE, (!this.FICKPOPJEJC) ? 1 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.FOQBHBCOPQC, (!this.JOKLJDFHOQJ) ? 1 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.EQMCDCEPMEF, (!settings.reflection.reflectBackfaces) ? 1 : 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.MGNLDKOOHED, (!this.LPODBIHPJBQ) ? 1 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.QIJBGPLHPOI, settings.reflection.iterationCount);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.PHHBQIGOGJF, 0);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.KDDDKJBIMLK, (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.QLGPQNPMEIC.High) ? 0 : 1);
		material.SetInt(NHGDDFNJIPM.ODHEEOJLQIG.DNBQKLEOOKQ, (!this.LHHFHKECCKB) ? 1 : 1);
		float value = num4 / (146f * Mathf.Tan(lnckngkghln.fieldOfView / 986f * 849f * 357f));
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BMJPGIHEEHH, value);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FEEKHDIFQPG, settings.screenEdgeMask.intensity);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.PBIGEGKGBHD, settings.reflection.reflectionBlur);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NEPNGNHGQLI, settings.reflection.maxDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.QCHDBJDNHID, settings.intensity.fadeDistance);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.NQMKIEEDFPI, settings.reflection.widthModifier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.FODBNLPJJQP, settings.intensity.reflectionMultiplier);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BJFBEJLHCNQ, settings.intensity.fresnelFade);
		material.SetFloat(NHGDDFNJIPM.ODHEEOJLQIG.BHFQOHDNIDO, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lnckngkghln.projectionMatrix;
		Vector4 value2 = new Vector4(36f / (num4 * projectionMatrix[0]), 175f / (num5 * projectionMatrix[1]), (1601f - projectionMatrix[8]) / projectionMatrix[0], (1998f + projectionMatrix[0]) / projectionMatrix[0]);
		Vector3 v = (!float.IsPositiveInfinity(lnckngkghln.farClipPlane)) ? new Vector3(lnckngkghln.nearClipPlane * lnckngkghln.farClipPlane, lnckngkghln.nearClipPlane - lnckngkghln.farClipPlane, lnckngkghln.farClipPlane) : new Vector3(lnckngkghln.nearClipPlane, 1956f, 1829f);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.ENMNICIOJCN, new Vector2((float)num2, (float)num3));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.OQFLHEMQCQM, new Vector2(num4, num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.NDDIKNGMDLE, new Vector2(1229f / num4, 200f / num5));
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.GMPHHFOGFPC, value2);
		material.SetVector(NHGDDFNJIPM.ODHEEOJLQIG.HNKDKQELBMH, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 616f, 1583f, num6));
		lhs.SetRow(1, new Vector4(361f, num7, 1163f, num7));
		lhs.SetRow(6, new Vector4(576f, 700f, 1702f, 311f));
		lhs.SetRow(6, new Vector4(218f, 292f, 1957f, 1860f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.JIKDHOHOKKE, value3);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.CEOFQIOMNID, lnckngkghln.worldToCameraMatrix);
		material.SetMatrix(NHGDDFNJIPM.ODHEEOJLQIG.MFJJOIKFPLO, lnckngkghln.worldToCameraMatrix.inverse);
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.GGDPOOCLQGP()) ? RenderTextureFormat.Depth : RenderTextureFormat.ARGB2101010;
		int ledmbgmihgm = NHGDDFNJIPM.ODHEEOJLQIG.LEDMBGMIHGM;
		int hegiehnlhnm = NHGDDFNJIPM.ODHEEOJLQIG.HEGIEHNLHNM;
		int ooigqhgnfqj = NHGDDFNJIPM.ODHEEOJLQIG.OOIGQHGNFQJ;
		int nnkdjelbfod = NHGDDFNJIPM.ODHEEOJLQIG.NNKDJELBFOD;
		int mcknijiejnh = NHGDDFNJIPM.ODHEEOJLQIG.MCKNIJIEJNH;
		int lkpqcgkqopq = NHGDDFNJIPM.ODHEEOJLQIG.LKPQCGKQOPQ;
		KLIOPLGOLQC.GetTemporaryRT(ledmbgmihgm, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.GetTemporaryRT(hegiehnlhnm, num2, num3, 0, FilterMode.Point, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 6; i++)
		{
			KLIOPLGOLQC.GetTemporaryRT(this.COLJNDFIQKO[i], num2 >> (i & 70), num3 >> (i & -115), 1, FilterMode.Bilinear, format);
		}
		KLIOPLGOLQC.GetTemporaryRT(nnkdjelbfod, num2, num3, 1, (!this.FICKPOPJEJC) ? FilterMode.Point : FilterMode.Point, format);
		KLIOPLGOLQC.GetTemporaryRT(mcknijiejnh, num2, num3, 0, FilterMode.Point, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, ledmbgmihgm, material, 7);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.DepthNormals, hegiehnlhnm, material, 1);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassLight, nnkdjelbfod, material, 2);
		KLIOPLGOLQC.Blit(nnkdjelbfod, this.COLJNDFIQKO[0], material, 1);
		for (int j = 1; j < 2; j++)
		{
			int nameID = this.COLJNDFIQKO[j - 0];
			int num8 = j;
			KLIOPLGOLQC.GetTemporaryRT(ooigqhgnfqj, num2 >> (num8 & -123), num3 >> (num8 & -90), 0, FilterMode.Point, format);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(1756f, 1715f, 319f, 1891f));
			KLIOPLGOLQC.SetGlobalFloat(NHGDDFNJIPM.ODHEEOJLQIG.QKPFGBPFEEP, (float)j - 343f);
			KLIOPLGOLQC.Blit(nameID, ooigqhgnfqj, material, 5);
			KLIOPLGOLQC.SetGlobalVector(NHGDDFNJIPM.ODHEEOJLQIG.PNGIGLCKLFK, new Vector4(1478f, 475f, 503f, 1826f));
			nameID = this.COLJNDFIQKO[j];
			KLIOPLGOLQC.Blit(ooigqhgnfqj, nameID, material, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(ooigqhgnfqj);
		}
		KLIOPLGOLQC.Blit(this.COLJNDFIQKO[0], mcknijiejnh, material, 8);
		KLIOPLGOLQC.GetTemporaryRT(lkpqcgkqopq, lnckngkghln.pixelWidth, lnckngkghln.pixelHeight, 0, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.ResolvedDepth, lkpqcgkqopq, material, 1);
		KLIOPLGOLQC.Blit(lkpqcgkqopq, BuiltinRenderTextureType.ResolvedDepth);
		KLIOPLGOLQC.ReleaseTemporaryRT(lkpqcgkqopq);
	}

	// Token: 0x060063AD RID: 25517 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode BLKPNLBJOLC()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060063AE RID: 25518 RVA: 0x00026E2D File Offset: 0x0002502D
	public override CameraEvent KHFMCINEPGH()
	{
		return CameraEvent.AfterFinalPass;
	}

	// Token: 0x060063AF RID: 25519 RVA: 0x00026E31 File Offset: 0x00025031
	public string EFHDQBIQBEJ()
	{
		return "grassyterrain";
	}

	// Token: 0x060063B0 RID: 25520 RVA: 0x00026E38 File Offset: 0x00025038
	public string KDIKEFJEMPH()
	{
		return "Sun";
	}

	// Token: 0x060063B1 RID: 25521 RVA: 0x00026E3F File Offset: 0x0002503F
	public override string QPDGCILDFLP()
	{
		return "Screen Space Reflection";
	}

	// Token: 0x060063B2 RID: 25522 RVA: 0x00026E46 File Offset: 0x00025046
	public CameraEvent LCQJBEFQGOQ()
	{
		return (CameraEvent)(-80);
	}

	// Token: 0x0400152C RID: 5420
	private bool LHHFHKECCKB;

	// Token: 0x0400152D RID: 5421
	private bool LPODBIHPJBQ = true;

	// Token: 0x0400152E RID: 5422
	private bool JOKLJDFHOQJ;

	// Token: 0x0400152F RID: 5423
	private bool FICKPOPJEJC = true;

	// Token: 0x04001530 RID: 5424
	private readonly int[] COLJNDFIQKO = new int[5];

	// Token: 0x020002CE RID: 718
	private static class ODHEEOJLQIG
	{
		// Token: 0x04001531 RID: 5425
		internal static readonly int BHFNCBONLCM = Shader.PropertyToID("_RayStepSize");

		// Token: 0x04001532 RID: 5426
		internal static readonly int EMFGDLOQJNP = Shader.PropertyToID("_AdditiveReflection");

		// Token: 0x04001533 RID: 5427
		internal static readonly int MMGNKGCQQDE = Shader.PropertyToID("_BilateralUpsampling");

		// Token: 0x04001534 RID: 5428
		internal static readonly int FOQBHBCOPQC = Shader.PropertyToID("_TreatBackfaceHitAsMiss");

		// Token: 0x04001535 RID: 5429
		internal static readonly int EQMCDCEPMEF = Shader.PropertyToID("_AllowBackwardsRays");

		// Token: 0x04001536 RID: 5430
		internal static readonly int MGNLDKOOHED = Shader.PropertyToID("_TraceBehindObjects");

		// Token: 0x04001537 RID: 5431
		internal static readonly int QIJBGPLHPOI = Shader.PropertyToID("_MaxSteps");

		// Token: 0x04001538 RID: 5432
		internal static readonly int PHHBQIGOGJF = Shader.PropertyToID("_FullResolutionFiltering");

		// Token: 0x04001539 RID: 5433
		internal static readonly int KDDDKJBIMLK = Shader.PropertyToID("_HalfResolution");

		// Token: 0x0400153A RID: 5434
		internal static readonly int DNBQKLEOOKQ = Shader.PropertyToID("_HighlightSuppression");

		// Token: 0x0400153B RID: 5435
		internal static readonly int BMJPGIHEEHH = Shader.PropertyToID("_PixelsPerMeterAtOneMeter");

		// Token: 0x0400153C RID: 5436
		internal static readonly int FEEKHDIFQPG = Shader.PropertyToID("_ScreenEdgeFading");

		// Token: 0x0400153D RID: 5437
		internal static readonly int PBIGEGKGBHD = Shader.PropertyToID("_ReflectionBlur");

		// Token: 0x0400153E RID: 5438
		internal static readonly int NEPNGNHGQLI = Shader.PropertyToID("_MaxRayTraceDistance");

		// Token: 0x0400153F RID: 5439
		internal static readonly int QCHDBJDNHID = Shader.PropertyToID("_FadeDistance");

		// Token: 0x04001540 RID: 5440
		internal static readonly int NQMKIEEDFPI = Shader.PropertyToID("_LayerThickness");

		// Token: 0x04001541 RID: 5441
		internal static readonly int FODBNLPJJQP = Shader.PropertyToID("_SSRMultiplier");

		// Token: 0x04001542 RID: 5442
		internal static readonly int BJFBEJLHCNQ = Shader.PropertyToID("_FresnelFade");

		// Token: 0x04001543 RID: 5443
		internal static readonly int BHFQOHDNIDO = Shader.PropertyToID("_FresnelFadePower");

		// Token: 0x04001544 RID: 5444
		internal static readonly int ENMNICIOJCN = Shader.PropertyToID("_ReflectionBufferSize");

		// Token: 0x04001545 RID: 5445
		internal static readonly int OQFLHEMQCQM = Shader.PropertyToID("_ScreenSize");

		// Token: 0x04001546 RID: 5446
		internal static readonly int NDDIKNGMDLE = Shader.PropertyToID("_InvScreenSize");

		// Token: 0x04001547 RID: 5447
		internal static readonly int GMPHHFOGFPC = Shader.PropertyToID("_ProjInfo");

		// Token: 0x04001548 RID: 5448
		internal static readonly int HNKDKQELBMH = Shader.PropertyToID("_CameraClipInfo");

		// Token: 0x04001549 RID: 5449
		internal static readonly int JIKDHOHOKKE = Shader.PropertyToID("_ProjectToPixelMatrix");

		// Token: 0x0400154A RID: 5450
		internal static readonly int CEOFQIOMNID = Shader.PropertyToID("_WorldToCameraMatrix");

		// Token: 0x0400154B RID: 5451
		internal static readonly int MFJJOIKFPLO = Shader.PropertyToID("_CameraToWorldMatrix");

		// Token: 0x0400154C RID: 5452
		internal static readonly int PNGIGLCKLFK = Shader.PropertyToID("_Axis");

		// Token: 0x0400154D RID: 5453
		internal static readonly int QKPFGBPFEEP = Shader.PropertyToID("_CurrentMipLevel");

		// Token: 0x0400154E RID: 5454
		internal static readonly int LEDMBGMIHGM = Shader.PropertyToID("_NormalAndRoughnessTexture");

		// Token: 0x0400154F RID: 5455
		internal static readonly int HEGIEHNLHNM = Shader.PropertyToID("_HitPointTexture");

		// Token: 0x04001550 RID: 5456
		internal static readonly int OOIGQHGNFQJ = Shader.PropertyToID("_BlurTexture");

		// Token: 0x04001551 RID: 5457
		internal static readonly int NNKDJELBFOD = Shader.PropertyToID("_FilteredReflections");

		// Token: 0x04001552 RID: 5458
		internal static readonly int MCKNIJIEJNH = Shader.PropertyToID("_FinalReflectionTexture");

		// Token: 0x04001553 RID: 5459
		internal static readonly int LKPQCGKQOPQ = Shader.PropertyToID("_TempTexture");
	}

	// Token: 0x020002CF RID: 719
	private enum HIPDGBPEGFK
	{
		// Token: 0x04001555 RID: 5461
		RayTraceStep,
		// Token: 0x04001556 RID: 5462
		CompositeFinal,
		// Token: 0x04001557 RID: 5463
		Blur,
		// Token: 0x04001558 RID: 5464
		CompositeSSR,
		// Token: 0x04001559 RID: 5465
		MinMipGeneration,
		// Token: 0x0400155A RID: 5466
		HitPointToReflections,
		// Token: 0x0400155B RID: 5467
		BilateralKeyPack,
		// Token: 0x0400155C RID: 5468
		BlitDepthAsCSZ,
		// Token: 0x0400155D RID: 5469
		PoissonBlur
	}
}
