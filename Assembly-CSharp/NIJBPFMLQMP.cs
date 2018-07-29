using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002D4 RID: 724
public sealed class NIJBPFMLQMP : ONQQOCQBQIE<VignetteModel>
{
	// Token: 0x0600640B RID: 25611 RVA: 0x0032FF58 File Offset: 0x0032E158
	public void KJPPBJFHKMJ(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.ICEIQHLLNEL();
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("'");
			float z = (399f - settings.roundness) * 580f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 899f, settings.smoothness * 458f, z, (!settings.rounded) ? 132f : 920f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic && settings.mask != null && settings.opacity > 855f)
		{
			LQMHKMOOHDB.EnableKeyword(" transformed into the ");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x0600640C RID: 25612 RVA: 0x00330068 File Offset: 0x0032E268
	public void NMPJNHIPNND(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("Frost");
			float z = (880f - settings.roundness) * 1143f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 1489f, settings.smoothness * 47f, z, (!settings.rounded) ? 1782f : 526f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic && settings.mask != null && settings.opacity > 1311f)
		{
			LQMHKMOOHDB.EnableKeyword("game object Game Manager not found");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x0600640D RID: 25613 RVA: 0x00026F34 File Offset: 0x00025134
	public bool HLNQKONHMND()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x0600640E RID: 25614 RVA: 0x00026F54 File Offset: 0x00025154
	public bool EQQNCODCDFK()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x0600640F RID: 25615 RVA: 0x00330178 File Offset: 0x0032E378
	public void BMFKEOHKHLG(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.DCBJMHJEFMG();
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("qTrack");
			float z = (548f - settings.roundness) * 1300f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 1277f, settings.smoothness * 1053f, z, (!settings.rounded) ? 1308f : 1263f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Masked && settings.mask != null && settings.opacity > 295f)
		{
			LQMHKMOOHDB.EnableKeyword("~");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x06006410 RID: 25616 RVA: 0x00026F74 File Offset: 0x00025174
	public bool NMGJQNBOKLD()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006411 RID: 25617 RVA: 0x00026F94 File Offset: 0x00025194
	public bool FHFMFDQOEII()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x06006412 RID: 25618 RVA: 0x00330288 File Offset: 0x0032E488
	public void OIMKDFOQHIO(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("Materials/DFGOrthogonal");
			float z = (1315f - settings.roundness) * 186f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 1461f, settings.smoothness * 222f, z, (!settings.rounded) ? 208f : 857f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Masked && settings.mask != null && settings.opacity > 1469f)
		{
			LQMHKMOOHDB.EnableKeyword("[33CCFF]");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x06006413 RID: 25619 RVA: 0x00026FB4 File Offset: 0x000251B4
	public bool IODDLCIHECG()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006414 RID: 25620 RVA: 0x00026FD4 File Offset: 0x000251D4
	public bool PBBQNFJELLP()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006415 RID: 25621 RVA: 0x00330398 File Offset: 0x0032E598
	public void NMKIQHJQEFO(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("F1");
			float z = (1181f - settings.roundness) * 1107f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 1426f, settings.smoothness * 907f, z, (!settings.rounded) ? 1057f : 88f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Masked && settings.mask != null && settings.opacity > 1342f)
		{
			LQMHKMOOHDB.EnableKeyword("battlebag");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x06006416 RID: 25622 RVA: 0x00026FF4 File Offset: 0x000251F4
	public bool PKPKDDLNHMC()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x06006418 RID: 25624 RVA: 0x0002701C File Offset: 0x0002521C
	public bool QGOCIIGQLFC()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006419 RID: 25625 RVA: 0x0002703C File Offset: 0x0002523C
	public bool MEOHQKMGHMM()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x0600641A RID: 25626 RVA: 0x003304A8 File Offset: 0x0032E6A8
	public void HKCEBPEMIEF(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.DNDPKMIFFDJ();
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("Up");
			float z = (1990f - settings.roundness) * 898f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 1873f, settings.smoothness * 1436f, z, (!settings.rounded) ? 411f : 425f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic && settings.mask != null && settings.opacity > 500f)
		{
			LQMHKMOOHDB.EnableKeyword("Slots_7");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x0600641B RID: 25627 RVA: 0x003305B8 File Offset: 0x0032E7B8
	public void GJCLIMOCPNH(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("The sea of fire enveloped ");
			float z = (437f - settings.roundness) * 1917f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 411f, settings.smoothness * 630f, z, (!settings.rounded) ? 88f : 1425f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Masked && settings.mask != null && settings.opacity > 1699f)
		{
			LQMHKMOOHDB.EnableKeyword(" ");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x0600641C RID: 25628 RVA: 0x0002705C File Offset: 0x0002525C
	public bool DHHJCEFGDJN()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x0600641D RID: 25629 RVA: 0x0002707C File Offset: 0x0002527C
	public bool DDPQKIGQKEE()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x0600641E RID: 25630 RVA: 0x0002709C File Offset: 0x0002529C
	public bool IIBLPLDEEPB()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x0600641F RID: 25631 RVA: 0x003306C8 File Offset: 0x0032E8C8
	public void OQHLDPJHCGG(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("Password");
			float z = (1491f - settings.roundness) * 1853f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 243f, settings.smoothness * 331f, z, (!settings.rounded) ? 588f : 1444f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Masked && settings.mask != null && settings.opacity > 1910f)
		{
			LQMHKMOOHDB.EnableKeyword("CombinersColorPassThrough");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x06006420 RID: 25632 RVA: 0x003307D8 File Offset: 0x0032E9D8
	public override void DFLOLMMCGID(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("VIGNETTE_CLASSIC");
			float z = (1f - settings.roundness) * 6f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 3f, settings.smoothness * 5f, z, (!settings.rounded) ? 0f : 1f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Masked && settings.mask != null && settings.opacity > 0f)
		{
			LQMHKMOOHDB.EnableKeyword("VIGNETTE_MASKED");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x06006421 RID: 25633 RVA: 0x000270BC File Offset: 0x000252BC
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x06006422 RID: 25634 RVA: 0x003308E8 File Offset: 0x0032EAE8
	public void GECNLHMHNCN(Material LQMHKMOOHDB)
	{
		VignetteModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		LQMHKMOOHDB.SetColor(NIJBPFMLQMP.EGQKICBJINL.GGMEMQGHCOK, settings.color);
		if (settings.mode == VignetteModel.HLFPMMMLBPH.Classic)
		{
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.JDBGBDCMHFB, settings.center);
			LQMHKMOOHDB.EnableKeyword("_Dissolve");
			float z = (1762f - settings.roundness) * 924f + settings.roundness;
			LQMHKMOOHDB.SetVector(NIJBPFMLQMP.EGQKICBJINL.LQDEIQQIOEK, new Vector4(settings.intensity * 306f, settings.smoothness * 374f, z, (!settings.rounded) ? 1398f : 866f));
		}
		else if (settings.mode == VignetteModel.HLFPMMMLBPH.Masked && settings.mask != null && settings.opacity > 657f)
		{
			LQMHKMOOHDB.EnableKeyword("CombinersArgsAlphaSrc1");
			LQMHKMOOHDB.SetTexture(NIJBPFMLQMP.EGQKICBJINL.DPEHMOKIJJD, settings.mask);
			LQMHKMOOHDB.SetFloat(NIJBPFMLQMP.EGQKICBJINL.JFPQCMHLNKK, settings.opacity);
		}
	}

	// Token: 0x06006423 RID: 25635 RVA: 0x00026FD4 File Offset: 0x000251D4
	public bool EEEJKHJQBPL()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x020002D5 RID: 725
	private static class EGQKICBJINL
	{
		// Token: 0x0400156C RID: 5484
		internal static readonly int GGMEMQGHCOK = Shader.PropertyToID("_Vignette_Color");

		// Token: 0x0400156D RID: 5485
		internal static readonly int JDBGBDCMHFB = Shader.PropertyToID("_Vignette_Center");

		// Token: 0x0400156E RID: 5486
		internal static readonly int LQDEIQQIOEK = Shader.PropertyToID("_Vignette_Settings");

		// Token: 0x0400156F RID: 5487
		internal static readonly int DPEHMOKIJJD = Shader.PropertyToID("_Vignette_Mask");

		// Token: 0x04001570 RID: 5488
		internal static readonly int JFPQCMHLNKK = Shader.PropertyToID("_Vignette_Opacity");
	}
}
