using System;
using UnityEngine;

// Token: 0x0200024B RID: 587
[ExecuteInEditMode]
public class PokeShaderReset : MonoBehaviour
{
	// Token: 0x06005007 RID: 20487 RVA: 0x000205D1 File Offset: 0x0001E7D1
	public void Startup()
	{
		this.Renderer = base.GetComponent<SkinnedMeshRenderer>();
		if (this.Initialized)
		{
			this.UpdateMaterial();
		}
		else
		{
			this.GetFromMaterial();
		}
	}

	// Token: 0x06005008 RID: 20488 RVA: 0x000205F5 File Offset: 0x0001E7F5
	private void Start()
	{
		this.Startup();
	}

	// Token: 0x06005009 RID: 20489 RVA: 0x000205FD File Offset: 0x0001E7FD
	private void OnApplicationFocus()
	{
		if (this.Initialized)
		{
			this.UpdateMaterial();
		}
	}

	// Token: 0x0600500A RID: 20490 RVA: 0x0002060D File Offset: 0x0001E80D
	private void Update()
	{
		if (this.update)
		{
			this.UpdateMaterial();
			this.update = false;
		}
	}

	// Token: 0x0600500B RID: 20491 RVA: 0x0029B694 File Offset: 0x00299894
	public void GetFromMaterial()
	{
		Material sharedMaterial = this.Renderer.sharedMaterial;
		this.CombinersColorPassThrough = sharedMaterial.GetFloatArray("CombinersColorPassThrough");
		this.CombinersAlphaPassThrough = sharedMaterial.GetFloatArray("CombinersAlphaPassThrough");
		this.CombinersColorCombine = sharedMaterial.GetFloatArray("CombinersColorCombine");
		this.CombinersAlphaCombine = sharedMaterial.GetFloatArray("CombinersAlphaCombine");
		this.CombinersColorScale = sharedMaterial.GetFloatArray("CombinersColorScale");
		this.CombinersAlphaScale = sharedMaterial.GetFloatArray("CombinersAlphaScale");
		this.CombinersUpColorBuff = sharedMaterial.GetFloatArray("CombinersUpColorBuff");
		this.CombinersUpAlphaBuff = sharedMaterial.GetFloatArray("CombinersUpAlphaBuff");
		this.CombinersArgsColorSrc0 = sharedMaterial.GetFloatArray("CombinersArgsColorSrc0");
		this.CombinersArgsAlphaSrc0 = sharedMaterial.GetFloatArray("CombinersArgsAlphaSrc0");
		this.CombinersArgsColorOp0 = sharedMaterial.GetFloatArray("CombinersArgsColorOp0");
		this.CombinersArgsAlphaOp0 = sharedMaterial.GetFloatArray("CombinersArgsAlphaOp0");
		this.CombinersArgsColorSrc1 = sharedMaterial.GetFloatArray("CombinersArgsColorSrc1");
		this.CombinersArgsAlphaSrc1 = sharedMaterial.GetFloatArray("CombinersArgsAlphaSrc1");
		this.CombinersArgsColorOp1 = sharedMaterial.GetFloatArray("CombinersArgsColorOp1");
		this.CombinersArgsAlphaOp1 = sharedMaterial.GetFloatArray("CombinersArgsAlphaOp1");
		this.CombinersArgsColorSrc2 = sharedMaterial.GetFloatArray("CombinersArgsColorSrc2");
		this.CombinersArgsAlphaSrc2 = sharedMaterial.GetFloatArray("CombinersArgsAlphaSrc2");
		this.CombinersArgsColorOp2 = sharedMaterial.GetFloatArray("CombinersArgsColorOp2");
		this.CombinersArgsAlphaOp2 = sharedMaterial.GetFloatArray("CombinersArgsAlphaOp2");
		this.CombinersColor = sharedMaterial.GetColorArray("CombinersColor");
		this.Dist0 = sharedMaterial.GetFloatArray("Dist0");
		this.Dist1 = sharedMaterial.GetFloatArray("Dist1");
		this.Fresnel = sharedMaterial.GetFloatArray("Fresnel");
		this.ReflecR = sharedMaterial.GetFloatArray("ReflecR");
		this.ReflecG = sharedMaterial.GetFloatArray("ReflecG");
		this.ReflecB = sharedMaterial.GetFloatArray("ReflecB");
		this.Initialized = true;
	}

	// Token: 0x0600500C RID: 20492 RVA: 0x0029B880 File Offset: 0x00299A80
	public void UpdateMaterial()
	{
		Material sharedMaterial = this.Renderer.sharedMaterial;
		sharedMaterial.SetFloatArray("CombinersColorPassThrough", this.CombinersColorPassThrough);
		sharedMaterial.SetFloatArray("CombinersAlphaPassThrough", this.CombinersAlphaPassThrough);
		sharedMaterial.SetFloatArray("CombinersColorCombine", this.CombinersColorCombine);
		sharedMaterial.SetFloatArray("CombinersAlphaCombine", this.CombinersAlphaCombine);
		sharedMaterial.SetFloatArray("CombinersColorScale", this.CombinersColorScale);
		sharedMaterial.SetFloatArray("CombinersAlphaScale", this.CombinersAlphaScale);
		sharedMaterial.SetFloatArray("CombinersUpColorBuff", this.CombinersUpColorBuff);
		sharedMaterial.SetFloatArray("CombinersUpAlphaBuff", this.CombinersUpAlphaBuff);
		sharedMaterial.SetFloatArray("CombinersArgsColorSrc0", this.CombinersArgsColorSrc0);
		sharedMaterial.SetFloatArray("CombinersArgsAlphaSrc0", this.CombinersArgsAlphaSrc0);
		sharedMaterial.SetFloatArray("CombinersArgsColorOp0", this.CombinersArgsColorOp0);
		sharedMaterial.SetFloatArray("CombinersArgsAlphaOp0", this.CombinersArgsAlphaOp0);
		sharedMaterial.SetFloatArray("CombinersArgsColorSrc1", this.CombinersArgsColorSrc1);
		sharedMaterial.SetFloatArray("CombinersArgsAlphaSrc1", this.CombinersArgsAlphaSrc1);
		sharedMaterial.SetFloatArray("CombinersArgsColorOp1", this.CombinersArgsColorOp1);
		sharedMaterial.SetFloatArray("CombinersArgsAlphaOp1", this.CombinersArgsAlphaOp1);
		sharedMaterial.SetFloatArray("CombinersArgsColorSrc2", this.CombinersArgsColorSrc2);
		sharedMaterial.SetFloatArray("CombinersArgsAlphaSrc2", this.CombinersArgsAlphaSrc2);
		sharedMaterial.SetFloatArray("CombinersArgsColorOp2", this.CombinersArgsColorOp2);
		sharedMaterial.SetFloatArray("CombinersArgsAlphaOp2", this.CombinersArgsAlphaOp2);
		sharedMaterial.SetColorArray("CombinersColor", this.CombinersColor);
		if (this.Dist0 != null && this.Dist0.Length > 0)
		{
			sharedMaterial.SetFloatArray("Dist0", this.Dist0);
		}
		if (this.Dist1 != null && this.Dist1.Length > 0)
		{
			sharedMaterial.SetFloatArray("Dist1", this.Dist1);
		}
		if (this.Fresnel != null && this.Fresnel.Length > 0)
		{
			sharedMaterial.SetFloatArray("Fresnel", this.Fresnel);
		}
		if (this.ReflecR != null && this.ReflecR.Length > 0)
		{
			sharedMaterial.SetFloatArray("ReflecR", this.ReflecR);
		}
		if (this.ReflecG != null && this.ReflecG.Length > 0)
		{
			sharedMaterial.SetFloatArray("ReflecG", this.ReflecG);
		}
		if (this.ReflecB != null && this.ReflecB.Length > 0)
		{
			sharedMaterial.SetFloatArray("ReflecB", this.ReflecB);
		}
	}

	// Token: 0x0400112E RID: 4398
	public SkinnedMeshRenderer Renderer;

	// Token: 0x0400112F RID: 4399
	public float[] CombinersColorPassThrough;

	// Token: 0x04001130 RID: 4400
	public float[] CombinersAlphaPassThrough;

	// Token: 0x04001131 RID: 4401
	public float[] CombinersColorCombine;

	// Token: 0x04001132 RID: 4402
	public float[] CombinersAlphaCombine;

	// Token: 0x04001133 RID: 4403
	public float[] CombinersColorScale;

	// Token: 0x04001134 RID: 4404
	public float[] CombinersAlphaScale;

	// Token: 0x04001135 RID: 4405
	public float[] CombinersUpColorBuff;

	// Token: 0x04001136 RID: 4406
	public float[] CombinersUpAlphaBuff;

	// Token: 0x04001137 RID: 4407
	public float[] CombinersArgsColorSrc0;

	// Token: 0x04001138 RID: 4408
	public float[] CombinersArgsAlphaSrc0;

	// Token: 0x04001139 RID: 4409
	public float[] CombinersArgsColorOp0;

	// Token: 0x0400113A RID: 4410
	public float[] CombinersArgsAlphaOp0;

	// Token: 0x0400113B RID: 4411
	public float[] CombinersArgsColorSrc1;

	// Token: 0x0400113C RID: 4412
	public float[] CombinersArgsAlphaSrc1;

	// Token: 0x0400113D RID: 4413
	public float[] CombinersArgsColorOp1;

	// Token: 0x0400113E RID: 4414
	public float[] CombinersArgsAlphaOp1;

	// Token: 0x0400113F RID: 4415
	public float[] CombinersArgsColorSrc2;

	// Token: 0x04001140 RID: 4416
	public float[] CombinersArgsAlphaSrc2;

	// Token: 0x04001141 RID: 4417
	public float[] CombinersArgsColorOp2;

	// Token: 0x04001142 RID: 4418
	public float[] CombinersArgsAlphaOp2;

	// Token: 0x04001143 RID: 4419
	public Color[] CombinersColor;

	// Token: 0x04001144 RID: 4420
	public float[] Dist0;

	// Token: 0x04001145 RID: 4421
	public float[] Dist1;

	// Token: 0x04001146 RID: 4422
	public float[] Fresnel;

	// Token: 0x04001147 RID: 4423
	public float[] ReflecR;

	// Token: 0x04001148 RID: 4424
	public float[] ReflecG;

	// Token: 0x04001149 RID: 4425
	public float[] ReflecB;

	// Token: 0x0400114A RID: 4426
	[SerializeField]
	[HideInInspector]
	private bool Initialized;

	// Token: 0x0400114B RID: 4427
	public bool update;
}
