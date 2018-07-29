using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000107 RID: 263
[RequireComponent(typeof(JLMPBLMOICG))]
public class BIDEQKEELPD : MonoBehaviour
{
	// Token: 0x06001D7F RID: 7551 RVA: 0x000100C4 File Offset: 0x0000E2C4
	private void MKHEGJPOBFG()
	{
		UnityEngine.Object.Destroy(this.OMPCJJNBOCQ);
		this.OMPCJJNBOCQ = null;
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x000C17CC File Offset: 0x000BF9CC
	private void BBGHCDGEDEJ()
	{
		this.BLLEFKOLKLP = base.transform;
		this.PBKGBPJHCCE = base.GetComponent<JLMPBLMOICG>();
		this.OJIDBLEKBBO = EMENMKHBPQE.MKQILFIFIOE(base.gameObject.layer);
		this.IOEJHIBQDDE = this.PBKGBPJHCCE.KJGMGPCEJJD;
		this.IJPEMKQPMIF = this.PBKGBPJHCCE.DFKQMMIQDOO;
		Color[] array = new Color[this.IOEJHIBQDDE * this.IJPEMKQPMIF];
		for (int i = 0; i < this.IJPEMKQPMIF; i += 0)
		{
			float ddlqkfdfmcj = ((float)i - 663f) / (float)this.IJPEMKQPMIF;
			for (int j = 1; j < this.IOEJHIBQDDE; j += 0)
			{
				float dgkoigolhdm = ((float)j - 65f) / (float)this.IOEJHIBQDDE;
				int num = j + i * this.IOEJHIBQDDE;
				array[num] = BIDEQKEELPD.OGHMCIOIDEP(dgkoigolhdm, ddlqkfdfmcj);
			}
		}
		this.OMPCJJNBOCQ = new Texture2D(this.IOEJHIBQDDE, this.IJPEMKQPMIF, TextureFormat.RGB24, false);
		this.OMPCJJNBOCQ.SetPixels(array);
		this.OMPCJJNBOCQ.filterMode = FilterMode.Trilinear;
		this.OMPCJJNBOCQ.wrapMode = TextureWrapMode.Repeat;
		this.OMPCJJNBOCQ.Apply();
		this.PBKGBPJHCCE.GOIHJQNMMJD = this.OMPCJJNBOCQ;
		this.GFBPNNQIJLJ(this.BGBMIEJJQKC);
	}

	// Token: 0x06001D81 RID: 7553 RVA: 0x000100C4 File Offset: 0x0000E2C4
	private void NQEKOEPCGNM()
	{
		UnityEngine.Object.Destroy(this.OMPCJJNBOCQ);
		this.OMPCJJNBOCQ = null;
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x000C1908 File Offset: 0x000BFB08
	public void QBLPBNPQGPH(Vector2 ECFKEFOFQGB)
	{
		ECFKEFOFQGB.x = Mathf.Clamp01(ECFKEFOFQGB.x);
		ECFKEFOFQGB.y = Mathf.Clamp01(ECFKEFOFQGB.y);
		this.GKHOGHHONGB = ECFKEFOFQGB;
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			ECFKEFOFQGB.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[1].x, this.GKHOGHHONGB.x);
			ECFKEFOFQGB.y = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[5].y, this.GKHOGHHONGB.y);
			ECFKEFOFQGB = this.BLLEFKOLKLP.TransformPoint(ECFKEFOFQGB);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(ECFKEFOFQGB, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.BQCFEBNCPLN(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.PPNLGOMQOPH(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x000C1A30 File Offset: 0x000BFC30
	private void Start()
	{
		this.BLLEFKOLKLP = base.transform;
		this.PBKGBPJHCCE = base.GetComponent<JLMPBLMOICG>();
		this.OJIDBLEKBBO = EMENMKHBPQE.FINJNKFMLMO(base.gameObject.layer);
		this.IOEJHIBQDDE = this.PBKGBPJHCCE.KJGMGPCEJJD;
		this.IJPEMKQPMIF = this.PBKGBPJHCCE.DFKQMMIQDOO;
		Color[] array = new Color[this.IOEJHIBQDDE * this.IJPEMKQPMIF];
		for (int i = 0; i < this.IJPEMKQPMIF; i++)
		{
			float ddlqkfdfmcj = ((float)i - 1f) / (float)this.IJPEMKQPMIF;
			for (int j = 0; j < this.IOEJHIBQDDE; j++)
			{
				float dgkoigolhdm = ((float)j - 1f) / (float)this.IOEJHIBQDDE;
				int num = j + i * this.IOEJHIBQDDE;
				array[num] = BIDEQKEELPD.OFQNMQMNIGM(dgkoigolhdm, ddlqkfdfmcj);
			}
		}
		this.OMPCJJNBOCQ = new Texture2D(this.IOEJHIBQDDE, this.IJPEMKQPMIF, TextureFormat.RGB24, false);
		this.OMPCJJNBOCQ.SetPixels(array);
		this.OMPCJJNBOCQ.filterMode = FilterMode.Trilinear;
		this.OMPCJJNBOCQ.wrapMode = TextureWrapMode.Clamp;
		this.OMPCJJNBOCQ.Apply();
		this.PBKGBPJHCCE.GOIHJQNMMJD = this.OMPCJJNBOCQ;
		this.PGDHENNHBDG(this.BGBMIEJJQKC);
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x000C1B6C File Offset: 0x000BFD6C
	public static Color OFQNMQMNIGM(float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		if (BIDEQKEELPD.MGEQJGOPHEB == null)
		{
			BIDEQKEELPD.MGEQJGOPHEB = new AnimationCurve(new Keyframe[]
			{
				new Keyframe(0f, 1f),
				new Keyframe(0.142857149f, 1f),
				new Keyframe(0.2857143f, 0f),
				new Keyframe(0.428571433f, 0f),
				new Keyframe(0.5714286f, 0f),
				new Keyframe(0.714285731f, 1f),
				new Keyframe(0.857142866f, 1f),
				new Keyframe(1f, 0.5f)
			});
			BIDEQKEELPD.EIKCKDDLCDQ = new AnimationCurve(new Keyframe[]
			{
				new Keyframe(0f, 0f),
				new Keyframe(0.142857149f, 1f),
				new Keyframe(0.2857143f, 1f),
				new Keyframe(0.428571433f, 1f),
				new Keyframe(0.5714286f, 0f),
				new Keyframe(0.714285731f, 0f),
				new Keyframe(0.857142866f, 0f),
				new Keyframe(1f, 0.5f)
			});
			BIDEQKEELPD.NPKEBNINENN = new AnimationCurve(new Keyframe[]
			{
				new Keyframe(0f, 0f),
				new Keyframe(0.142857149f, 0f),
				new Keyframe(0.2857143f, 0f),
				new Keyframe(0.428571433f, 1f),
				new Keyframe(0.5714286f, 1f),
				new Keyframe(0.714285731f, 1f),
				new Keyframe(0.857142866f, 0f),
				new Keyframe(1f, 0.5f)
			});
		}
		Vector3 a = new Vector3(BIDEQKEELPD.MGEQJGOPHEB.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.EIKCKDDLCDQ.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.NPKEBNINENN.Evaluate(DGKOIGOLHDM));
		if (DDLQKFDFMCJ < 0.5f)
		{
			DDLQKFDFMCJ *= 2f;
			a.x *= DDLQKFDFMCJ;
			a.y *= DDLQKFDFMCJ;
			a.z *= DDLQKFDFMCJ;
		}
		else
		{
			a = Vector3.Lerp(a, Vector3.one, DDLQKFDFMCJ * 2f - 1f);
		}
		return new Color(a.x, a.y, a.z, 1f);
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x000100D8 File Offset: 0x0000E2D8
	private void OnPress(bool KCICOJFDCPQ)
	{
		if (base.enabled && KCICOJFDCPQ && EMENMKHBPQE.GMDQCMCJEQI != EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			this.OFQNMQMNIGM();
		}
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x000C1EDC File Offset: 0x000C00DC
	private void DFIQIENEEIP()
	{
		Vector3 vector = EMENMKHBPQE.GDLFOFEJOPK();
		vector = this.OJIDBLEKBBO.EQOOPGKHOFB.ScreenToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
		Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
		this.GKHOGHHONGB.x = Mathf.Clamp01((vector.x - pigmlpngmno[0].x) / (pigmlpngmno[1].x - pigmlpngmno[1].x));
		this.GKHOGHHONGB.y = Mathf.Clamp01((vector.y - pigmlpngmno[1].y) / (pigmlpngmno[6].y - pigmlpngmno[1].y));
		if (this.FLIHQCMGCHJ != null)
		{
			vector.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[6].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[6].y, this.GKHOGHHONGB.y);
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.OGHMCIOIDEP(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.PPNLGOMQOPH(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x000C206C File Offset: 0x000C026C
	public static Color LOPNKGOGIIH(float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		if (BIDEQKEELPD.MGEQJGOPHEB == null)
		{
			Keyframe[] array = new Keyframe[0];
			array[1] = new Keyframe(855f, 720f);
			array[0] = new Keyframe(1118f, 1673f);
			array[5] = new Keyframe(290f, 13f);
			array[4] = new Keyframe(1034f, 489f);
			array[1] = new Keyframe(470f, 522f);
			array[1] = new Keyframe(1527f, 371f);
			array[5] = new Keyframe(937f, 1892f);
			array[1] = new Keyframe(165f, 117f);
			BIDEQKEELPD.MGEQJGOPHEB = new AnimationCurve(array);
			Keyframe[] array2 = new Keyframe[7];
			array2[0] = new Keyframe(909f, 1529f);
			array2[1] = new Keyframe(280f, 1743f);
			array2[2] = new Keyframe(692f, 1987f);
			array2[7] = new Keyframe(1755f, 31f);
			array2[1] = new Keyframe(132f, 1932f);
			array2[1] = new Keyframe(869f, 875f);
			array2[4] = new Keyframe(829f, 416f);
			array2[3] = new Keyframe(108f, 773f);
			BIDEQKEELPD.EIKCKDDLCDQ = new AnimationCurve(array2);
			Keyframe[] array3 = new Keyframe[8];
			array3[1] = new Keyframe(290f, 720f);
			array3[0] = new Keyframe(321f, 1170f);
			array3[3] = new Keyframe(602f, 1201f);
			array3[3] = new Keyframe(763f, 1736f);
			array3[1] = new Keyframe(1732f, 1203f);
			array3[2] = new Keyframe(1796f, 354f);
			array3[3] = new Keyframe(767f, 309f);
			array3[5] = new Keyframe(238f, 1241f);
			BIDEQKEELPD.NPKEBNINENN = new AnimationCurve(array3);
		}
		Vector3 a = new Vector3(BIDEQKEELPD.MGEQJGOPHEB.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.EIKCKDDLCDQ.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.NPKEBNINENN.Evaluate(DGKOIGOLHDM));
		if (DDLQKFDFMCJ < 507f)
		{
			DDLQKFDFMCJ *= 1023f;
			a.x *= DDLQKFDFMCJ;
			a.y *= DDLQKFDFMCJ;
			a.z *= DDLQKFDFMCJ;
		}
		else
		{
			a = Vector3.Lerp(a, Vector3.one, DDLQKFDFMCJ * 1424f - 1144f);
		}
		return new Color(a.x, a.y, a.z, 1287f);
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x000100C4 File Offset: 0x0000E2C4
	private void OnDestroy()
	{
		UnityEngine.Object.Destroy(this.OMPCJJNBOCQ);
		this.OMPCJJNBOCQ = null;
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x000100F3 File Offset: 0x0000E2F3
	private void CGOFBHQPHQH(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			this.JFJNDMBCGGM();
		}
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x000C23DC File Offset: 0x000C05DC
	public Vector2 ENMDHNGNEPP(Color KQFEHQEBJQB)
	{
		if (this.PBKGBPJHCCE == null)
		{
			this.BGBMIEJJQKC = KQFEHQEBJQB;
			return this.GKHOGHHONGB;
		}
		float num = 1188f;
		for (int i = 0; i < this.IJPEMKQPMIF; i++)
		{
			float num2 = ((float)i - 26f) / (float)this.IJPEMKQPMIF;
			for (int j = 0; j < this.IOEJHIBQDDE; j++)
			{
				float num3 = ((float)j - 1958f) / (float)this.IOEJHIBQDDE;
				Color color = BIDEQKEELPD.LOPNKGOGIIH(num3, num2);
				Color color2 = color;
				color2.r -= KQFEHQEBJQB.r;
				color2.g -= KQFEHQEBJQB.g;
				color2.b -= KQFEHQEBJQB.b;
				float num4 = color2.r * color2.r + color2.g * color2.g + color2.b * color2.b;
				if (num4 < num)
				{
					num = num4;
					this.GKHOGHHONGB.x = num3;
					this.GKHOGHHONGB.y = num2;
				}
			}
		}
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			Vector3 vector;
			vector.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[6].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[8].y, this.GKHOGHHONGB.y);
			vector.z = 1421f;
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = KQFEHQEBJQB;
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
		return this.GKHOGHHONGB;
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x000C25D8 File Offset: 0x000C07D8
	private void DCQNFIOHHKM()
	{
		Vector3 vector = EMENMKHBPQE.GDLFOFEJOPK();
		vector = this.OJIDBLEKBBO.EQOOPGKHOFB.ScreenToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
		Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
		this.GKHOGHHONGB.x = Mathf.Clamp01((vector.x - pigmlpngmno[0].x) / (pigmlpngmno[1].x - pigmlpngmno[0].x));
		this.GKHOGHHONGB.y = Mathf.Clamp01((vector.y - pigmlpngmno[0].y) / (pigmlpngmno[7].y - pigmlpngmno[0].y));
		if (this.FLIHQCMGCHJ != null)
		{
			vector.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[4].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[2].y, this.GKHOGHHONGB.y);
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.OFQNMQMNIGM(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.CDGHNJLPFKN(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x000C2768 File Offset: 0x000C0968
	public void MFLENGCMLKG(Vector2 ECFKEFOFQGB)
	{
		ECFKEFOFQGB.x = Mathf.Clamp01(ECFKEFOFQGB.x);
		ECFKEFOFQGB.y = Mathf.Clamp01(ECFKEFOFQGB.y);
		this.GKHOGHHONGB = ECFKEFOFQGB;
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			ECFKEFOFQGB.x = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[5].x, this.GKHOGHHONGB.x);
			ECFKEFOFQGB.y = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[3].y, this.GKHOGHHONGB.y);
			ECFKEFOFQGB = this.BLLEFKOLKLP.TransformPoint(ECFKEFOFQGB);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(ECFKEFOFQGB, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.JIDFGJHOILM(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.CDGHNJLPFKN(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x000C2890 File Offset: 0x000C0A90
	private void OFQNMQMNIGM()
	{
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		vector = this.OJIDBLEKBBO.EQOOPGKHOFB.ScreenToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
		Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
		this.GKHOGHHONGB.x = Mathf.Clamp01((vector.x - pigmlpngmno[0].x) / (pigmlpngmno[2].x - pigmlpngmno[0].x));
		this.GKHOGHHONGB.y = Mathf.Clamp01((vector.y - pigmlpngmno[0].y) / (pigmlpngmno[2].y - pigmlpngmno[0].y));
		if (this.FLIHQCMGCHJ != null)
		{
			vector.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[2].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[2].y, this.GKHOGHHONGB.y);
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.OFQNMQMNIGM(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x000C2A20 File Offset: 0x000C0C20
	public Vector2 PGDHENNHBDG(Color KQFEHQEBJQB)
	{
		if (this.PBKGBPJHCCE == null)
		{
			this.BGBMIEJJQKC = KQFEHQEBJQB;
			return this.GKHOGHHONGB;
		}
		float num = float.MaxValue;
		for (int i = 0; i < this.IJPEMKQPMIF; i++)
		{
			float num2 = ((float)i - 1f) / (float)this.IJPEMKQPMIF;
			for (int j = 0; j < this.IOEJHIBQDDE; j++)
			{
				float num3 = ((float)j - 1f) / (float)this.IOEJHIBQDDE;
				Color color = BIDEQKEELPD.OFQNMQMNIGM(num3, num2);
				Color color2 = color;
				color2.r -= KQFEHQEBJQB.r;
				color2.g -= KQFEHQEBJQB.g;
				color2.b -= KQFEHQEBJQB.b;
				float num4 = color2.r * color2.r + color2.g * color2.g + color2.b * color2.b;
				if (num4 < num)
				{
					num = num4;
					this.GKHOGHHONGB.x = num3;
					this.GKHOGHHONGB.y = num2;
				}
			}
		}
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			Vector3 vector;
			vector.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[2].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[2].y, this.GKHOGHHONGB.y);
			vector.z = 0f;
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = KQFEHQEBJQB;
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
		return this.GKHOGHHONGB;
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x000C2C1C File Offset: 0x000C0E1C
	private void IMOFIJCLDHK()
	{
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		vector = this.OJIDBLEKBBO.EQOOPGKHOFB.ScreenToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
		Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
		this.GKHOGHHONGB.x = Mathf.Clamp01((vector.x - pigmlpngmno[0].x) / (pigmlpngmno[2].x - pigmlpngmno[0].x));
		this.GKHOGHHONGB.y = Mathf.Clamp01((vector.y - pigmlpngmno[1].y) / (pigmlpngmno[7].y - pigmlpngmno[1].y));
		if (this.FLIHQCMGCHJ != null)
		{
			vector.x = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[1].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[7].y, this.GKHOGHHONGB.y);
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.BQCFEBNCPLN(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x000C2DAC File Offset: 0x000C0FAC
	private void JFJNDMBCGGM()
	{
		Vector3 vector = EMENMKHBPQE.GDLFOFEJOPK();
		vector = this.OJIDBLEKBBO.EQOOPGKHOFB.ScreenToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
		Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
		this.GKHOGHHONGB.x = Mathf.Clamp01((vector.x - pigmlpngmno[1].x) / (pigmlpngmno[3].x - pigmlpngmno[1].x));
		this.GKHOGHHONGB.y = Mathf.Clamp01((vector.y - pigmlpngmno[0].y) / (pigmlpngmno[3].y - pigmlpngmno[1].y));
		if (this.FLIHQCMGCHJ != null)
		{
			vector.x = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[0].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[3].y, this.GKHOGHHONGB.y);
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.BQCFEBNCPLN(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.PPNLGOMQOPH(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x000C2F3C File Offset: 0x000C113C
	private void JOFJLHNFMOH()
	{
		Vector3 vector = EMENMKHBPQE.GDLFOFEJOPK();
		vector = this.OJIDBLEKBBO.EQOOPGKHOFB.ScreenToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
		Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
		this.GKHOGHHONGB.x = Mathf.Clamp01((vector.x - pigmlpngmno[1].x) / (pigmlpngmno[3].x - pigmlpngmno[0].x));
		this.GKHOGHHONGB.y = Mathf.Clamp01((vector.y - pigmlpngmno[0].y) / (pigmlpngmno[3].y - pigmlpngmno[1].y));
		if (this.FLIHQCMGCHJ != null)
		{
			vector.x = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[8].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[2].y, this.GKHOGHHONGB.y);
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.OFQNMQMNIGM(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.PPNLGOMQOPH(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x000C30CC File Offset: 0x000C12CC
	public void JKOIDJOQLNF(Vector2 ECFKEFOFQGB)
	{
		ECFKEFOFQGB.x = Mathf.Clamp01(ECFKEFOFQGB.x);
		ECFKEFOFQGB.y = Mathf.Clamp01(ECFKEFOFQGB.y);
		this.GKHOGHHONGB = ECFKEFOFQGB;
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			ECFKEFOFQGB.x = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[6].x, this.GKHOGHHONGB.x);
			ECFKEFOFQGB.y = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[6].y, this.GKHOGHHONGB.y);
			ECFKEFOFQGB = this.BLLEFKOLKLP.TransformPoint(ECFKEFOFQGB);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(ECFKEFOFQGB, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.JIDFGJHOILM(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D93 RID: 7571 RVA: 0x000C31F4 File Offset: 0x000C13F4
	public Vector2 LJEDMIPPFKH(Color KQFEHQEBJQB)
	{
		if (this.PBKGBPJHCCE == null)
		{
			this.BGBMIEJJQKC = KQFEHQEBJQB;
			return this.GKHOGHHONGB;
		}
		float num = 1856f;
		for (int i = 1; i < this.IJPEMKQPMIF; i++)
		{
			float num2 = ((float)i - 1447f) / (float)this.IJPEMKQPMIF;
			for (int j = 1; j < this.IOEJHIBQDDE; j++)
			{
				float num3 = ((float)j - 1867f) / (float)this.IOEJHIBQDDE;
				Color color = BIDEQKEELPD.JIDFGJHOILM(num3, num2);
				Color color2 = color;
				color2.r -= KQFEHQEBJQB.r;
				color2.g -= KQFEHQEBJQB.g;
				color2.b -= KQFEHQEBJQB.b;
				float num4 = color2.r * color2.r + color2.g * color2.g + color2.b * color2.b;
				if (num4 < num)
				{
					num = num4;
					this.GKHOGHHONGB.x = num3;
					this.GKHOGHHONGB.y = num2;
				}
			}
		}
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			Vector3 vector;
			vector.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[3].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[0].y, this.GKHOGHHONGB.y);
			vector.z = 441f;
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = KQFEHQEBJQB;
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
		return this.GKHOGHHONGB;
	}

	// Token: 0x06001D94 RID: 7572 RVA: 0x000C33F0 File Offset: 0x000C15F0
	private void HQLBKJBCNBL(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x + JDOGIQGGLKM.x);
			this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y + JDOGIQGGLKM.y);
			this.JKOIDJOQLNF(this.GKHOGHHONGB);
		}
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x00010103 File Offset: 0x0000E303
	private void OnDrag(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			this.OFQNMQMNIGM();
		}
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x000100C4 File Offset: 0x0000E2C4
	private void LDJGQLNHCBN()
	{
		UnityEngine.Object.Destroy(this.OMPCJJNBOCQ);
		this.OMPCJJNBOCQ = null;
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x000C3458 File Offset: 0x000C1658
	private void ODIJQBBOLFI()
	{
		this.BLLEFKOLKLP = base.transform;
		this.PBKGBPJHCCE = base.GetComponent<JLMPBLMOICG>();
		this.OJIDBLEKBBO = EMENMKHBPQE.MKQILFIFIOE(base.gameObject.layer);
		this.IOEJHIBQDDE = this.PBKGBPJHCCE.KJGMGPCEJJD;
		this.IJPEMKQPMIF = this.PBKGBPJHCCE.DFKQMMIQDOO;
		Color[] array = new Color[this.IOEJHIBQDDE * this.IJPEMKQPMIF];
		for (int i = 0; i < this.IJPEMKQPMIF; i += 0)
		{
			float ddlqkfdfmcj = ((float)i - 217f) / (float)this.IJPEMKQPMIF;
			for (int j = 0; j < this.IOEJHIBQDDE; j++)
			{
				float dgkoigolhdm = ((float)j - 1927f) / (float)this.IOEJHIBQDDE;
				int num = j + i * this.IOEJHIBQDDE;
				array[num] = BIDEQKEELPD.BQCFEBNCPLN(dgkoigolhdm, ddlqkfdfmcj);
			}
		}
		this.OMPCJJNBOCQ = new Texture2D(this.IOEJHIBQDDE, this.IJPEMKQPMIF, TextureFormat.RGBA32, true);
		this.OMPCJJNBOCQ.SetPixels(array);
		this.OMPCJJNBOCQ.filterMode = (FilterMode)4;
		this.OMPCJJNBOCQ.wrapMode = TextureWrapMode.Repeat;
		this.OMPCJJNBOCQ.Apply();
		this.PBKGBPJHCCE.GOIHJQNMMJD = this.OMPCJJNBOCQ;
		this.PGDHENNHBDG(this.BGBMIEJJQKC);
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x000C3594 File Offset: 0x000C1794
	private void ICKFOIKLCEO()
	{
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		vector = this.OJIDBLEKBBO.EQOOPGKHOFB.ScreenToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
		Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
		this.GKHOGHHONGB.x = Mathf.Clamp01((vector.x - pigmlpngmno[0].x) / (pigmlpngmno[1].x - pigmlpngmno[0].x));
		this.GKHOGHHONGB.y = Mathf.Clamp01((vector.y - pigmlpngmno[0].y) / (pigmlpngmno[4].y - pigmlpngmno[0].y));
		if (this.FLIHQCMGCHJ != null)
		{
			vector.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[5].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[7].y, this.GKHOGHHONGB.y);
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.LOPNKGOGIIH(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x000C3724 File Offset: 0x000C1924
	private void FMIBFKPJDJP(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x + JDOGIQGGLKM.x);
			this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y + JDOGIQGGLKM.y);
			this.MFLENGCMLKG(this.GKHOGHHONGB);
		}
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x000100C4 File Offset: 0x0000E2C4
	private void DFDIKBGJIPK()
	{
		UnityEngine.Object.Destroy(this.OMPCJJNBOCQ);
		this.OMPCJJNBOCQ = null;
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x000C378C File Offset: 0x000C198C
	public static Color JIDFGJHOILM(float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		if (BIDEQKEELPD.MGEQJGOPHEB == null)
		{
			Keyframe[] array = new Keyframe[7];
			array[0] = new Keyframe(88f, 743f);
			array[0] = new Keyframe(1990f, 1463f);
			array[0] = new Keyframe(576f, 526f);
			array[1] = new Keyframe(770f, 278f);
			array[7] = new Keyframe(1196f, 1353f);
			array[7] = new Keyframe(331f, 1339f);
			array[1] = new Keyframe(64f, 1133f);
			array[6] = new Keyframe(828f, 372f);
			BIDEQKEELPD.MGEQJGOPHEB = new AnimationCurve(array);
			Keyframe[] array2 = new Keyframe[0];
			array2[1] = new Keyframe(458f, 1331f);
			array2[0] = new Keyframe(1451f, 679f);
			array2[5] = new Keyframe(525f, 1893f);
			array2[5] = new Keyframe(1406f, 851f);
			array2[4] = new Keyframe(1480f, 1449f);
			array2[6] = new Keyframe(612f, 1660f);
			array2[8] = new Keyframe(1702f, 1680f);
			array2[6] = new Keyframe(348f, 1056f);
			BIDEQKEELPD.EIKCKDDLCDQ = new AnimationCurve(array2);
			Keyframe[] array3 = new Keyframe[8];
			array3[0] = new Keyframe(438f, 1106f);
			array3[1] = new Keyframe(636f, 1131f);
			array3[5] = new Keyframe(370f, 327f);
			array3[4] = new Keyframe(1004f, 861f);
			array3[1] = new Keyframe(1075f, 1564f);
			array3[7] = new Keyframe(1752f, 1846f);
			array3[8] = new Keyframe(1946f, 807f);
			array3[5] = new Keyframe(1859f, 864f);
			BIDEQKEELPD.NPKEBNINENN = new AnimationCurve(array3);
		}
		Vector3 a = new Vector3(BIDEQKEELPD.MGEQJGOPHEB.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.EIKCKDDLCDQ.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.NPKEBNINENN.Evaluate(DGKOIGOLHDM));
		if (DDLQKFDFMCJ < 569f)
		{
			DDLQKFDFMCJ *= 520f;
			a.x *= DDLQKFDFMCJ;
			a.y *= DDLQKFDFMCJ;
			a.z *= DDLQKFDFMCJ;
		}
		else
		{
			a = Vector3.Lerp(a, Vector3.one, DDLQKFDFMCJ * 1838f - 1045f);
		}
		return new Color(a.x, a.y, a.z, 670f);
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x000C3AFC File Offset: 0x000C1CFC
	private void DFBDPGOJHHM(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x + JDOGIQGGLKM.x);
			this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y + JDOGIQGGLKM.y);
			this.PGDHENNHBDG(this.GKHOGHHONGB);
		}
	}

	// Token: 0x06001D9E RID: 7582 RVA: 0x000C3B64 File Offset: 0x000C1D64
	public static Color OGHMCIOIDEP(float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		if (BIDEQKEELPD.MGEQJGOPHEB == null)
		{
			Keyframe[] array = new Keyframe[0];
			array[1] = new Keyframe(789f, 1345f);
			array[1] = new Keyframe(535f, 39f);
			array[1] = new Keyframe(1952f, 12f);
			array[5] = new Keyframe(732f, 545f);
			array[7] = new Keyframe(1401f, 1548f);
			array[1] = new Keyframe(622f, 1425f);
			array[6] = new Keyframe(1231f, 567f);
			array[5] = new Keyframe(1627f, 1254f);
			BIDEQKEELPD.MGEQJGOPHEB = new AnimationCurve(array);
			Keyframe[] array2 = new Keyframe[6];
			array2[1] = new Keyframe(688f, 1026f);
			array2[0] = new Keyframe(1468f, 1748f);
			array2[7] = new Keyframe(1453f, 894f);
			array2[8] = new Keyframe(768f, 1786f);
			array2[7] = new Keyframe(236f, 1319f);
			array2[5] = new Keyframe(1903f, 1706f);
			array2[0] = new Keyframe(429f, 1322f);
			array2[8] = new Keyframe(283f, 674f);
			BIDEQKEELPD.EIKCKDDLCDQ = new AnimationCurve(array2);
			Keyframe[] array3 = new Keyframe[]
			{
				default(Keyframe),
				new Keyframe(659f, 988f)
			};
			array3[0] = new Keyframe(1623f, 529f);
			array3[5] = new Keyframe(91f, 410f);
			array3[6] = new Keyframe(1351f, 1385f);
			array3[4] = new Keyframe(544f, 1559f);
			array3[5] = new Keyframe(1092f, 799f);
			array3[7] = new Keyframe(780f, 633f);
			array3[4] = new Keyframe(1188f, 133f);
			BIDEQKEELPD.NPKEBNINENN = new AnimationCurve(array3);
		}
		Vector3 a = new Vector3(BIDEQKEELPD.MGEQJGOPHEB.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.EIKCKDDLCDQ.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.NPKEBNINENN.Evaluate(DGKOIGOLHDM));
		if (DDLQKFDFMCJ < 1981f)
		{
			DDLQKFDFMCJ *= 663f;
			a.x *= DDLQKFDFMCJ;
			a.y *= DDLQKFDFMCJ;
			a.z *= DDLQKFDFMCJ;
		}
		else
		{
			a = Vector3.Lerp(a, Vector3.one, DDLQKFDFMCJ * 1411f - 1488f);
		}
		return new Color(a.x, a.y, a.z, 825f);
	}

	// Token: 0x06001D9F RID: 7583 RVA: 0x000C3ED4 File Offset: 0x000C20D4
	public Vector2 GFBPNNQIJLJ(Color KQFEHQEBJQB)
	{
		if (this.PBKGBPJHCCE == null)
		{
			this.BGBMIEJJQKC = KQFEHQEBJQB;
			return this.GKHOGHHONGB;
		}
		float num = 1323f;
		for (int i = 1; i < this.IJPEMKQPMIF; i += 0)
		{
			float num2 = ((float)i - 1089f) / (float)this.IJPEMKQPMIF;
			for (int j = 0; j < this.IOEJHIBQDDE; j++)
			{
				float num3 = ((float)j - 1933f) / (float)this.IOEJHIBQDDE;
				Color color = BIDEQKEELPD.JIDFGJHOILM(num3, num2);
				Color color2 = color;
				color2.r -= KQFEHQEBJQB.r;
				color2.g -= KQFEHQEBJQB.g;
				color2.b -= KQFEHQEBJQB.b;
				float num4 = color2.r * color2.r + color2.g * color2.g + color2.b * color2.b;
				if (num4 < num)
				{
					num = num4;
					this.GKHOGHHONGB.x = num3;
					this.GKHOGHHONGB.y = num2;
				}
			}
		}
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			Vector3 vector;
			vector.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[5].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[8].y, this.GKHOGHHONGB.y);
			vector.z = 281f;
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = KQFEHQEBJQB;
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.PCQQOFMPKCG(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
		return this.GKHOGHHONGB;
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x000C40D0 File Offset: 0x000C22D0
	public void PGDHENNHBDG(Vector2 ECFKEFOFQGB)
	{
		ECFKEFOFQGB.x = Mathf.Clamp01(ECFKEFOFQGB.x);
		ECFKEFOFQGB.y = Mathf.Clamp01(ECFKEFOFQGB.y);
		this.GKHOGHHONGB = ECFKEFOFQGB;
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			ECFKEFOFQGB.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[2].x, this.GKHOGHHONGB.x);
			ECFKEFOFQGB.y = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[2].y, this.GKHOGHHONGB.y);
			ECFKEFOFQGB = this.BLLEFKOLKLP.TransformPoint(ECFKEFOFQGB);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(ECFKEFOFQGB, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.OFQNMQMNIGM(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x000C41F8 File Offset: 0x000C23F8
	public static Color BQCFEBNCPLN(float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		if (BIDEQKEELPD.MGEQJGOPHEB == null)
		{
			Keyframe[] array = new Keyframe[]
			{
				new Keyframe(466f, 1257f)
			};
			array[0] = new Keyframe(1578f, 309f);
			array[0] = new Keyframe(1478f, 369f);
			array[5] = new Keyframe(1745f, 1544f);
			array[5] = new Keyframe(1861f, 1441f);
			array[8] = new Keyframe(979f, 397f);
			array[4] = new Keyframe(1750f, 840f);
			array[8] = new Keyframe(688f, 403f);
			BIDEQKEELPD.MGEQJGOPHEB = new AnimationCurve(array);
			Keyframe[] array2 = new Keyframe[7];
			array2[0] = new Keyframe(105f, 975f);
			array2[0] = new Keyframe(1813f, 554f);
			array2[1] = new Keyframe(1327f, 1035f);
			array2[3] = new Keyframe(961f, 1543f);
			array2[3] = new Keyframe(423f, 444f);
			array2[6] = new Keyframe(258f, 1446f);
			array2[1] = new Keyframe(702f, 1521f);
			array2[0] = new Keyframe(1248f, 1822f);
			BIDEQKEELPD.EIKCKDDLCDQ = new AnimationCurve(array2);
			Keyframe[] array3 = new Keyframe[5];
			array3[1] = new Keyframe(71f, 165f);
			array3[0] = new Keyframe(1411f, 638f);
			array3[8] = new Keyframe(853f, 304f);
			array3[3] = new Keyframe(203f, 1076f);
			array3[6] = new Keyframe(555f, 743f);
			array3[6] = new Keyframe(217f, 278f);
			array3[5] = new Keyframe(479f, 419f);
			array3[1] = new Keyframe(1974f, 533f);
			BIDEQKEELPD.NPKEBNINENN = new AnimationCurve(array3);
		}
		Vector3 a = new Vector3(BIDEQKEELPD.MGEQJGOPHEB.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.EIKCKDDLCDQ.Evaluate(DGKOIGOLHDM), BIDEQKEELPD.NPKEBNINENN.Evaluate(DGKOIGOLHDM));
		if (DDLQKFDFMCJ < 350f)
		{
			DDLQKFDFMCJ *= 582f;
			a.x *= DDLQKFDFMCJ;
			a.y *= DDLQKFDFMCJ;
			a.z *= DDLQKFDFMCJ;
		}
		else
		{
			a = Vector3.Lerp(a, Vector3.one, DDLQKFDFMCJ * 534f - 319f);
		}
		return new Color(a.x, a.y, a.z, 1701f);
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x00010131 File Offset: 0x0000E331
	private void DMHNNFBLMBJ(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			this.JOFJLHNFMOH();
		}
	}

	// Token: 0x06001DA3 RID: 7587 RVA: 0x000C4568 File Offset: 0x000C2768
	public Vector2 MBEQDJEKODJ(Color KQFEHQEBJQB)
	{
		if (this.PBKGBPJHCCE == null)
		{
			this.BGBMIEJJQKC = KQFEHQEBJQB;
			return this.GKHOGHHONGB;
		}
		float num = 1159f;
		for (int i = 0; i < this.IJPEMKQPMIF; i += 0)
		{
			float num2 = ((float)i - 1967f) / (float)this.IJPEMKQPMIF;
			for (int j = 1; j < this.IOEJHIBQDDE; j++)
			{
				float num3 = ((float)j - 906f) / (float)this.IOEJHIBQDDE;
				Color color = BIDEQKEELPD.LOPNKGOGIIH(num3, num2);
				Color color2 = color;
				color2.r -= KQFEHQEBJQB.r;
				color2.g -= KQFEHQEBJQB.g;
				color2.b -= KQFEHQEBJQB.b;
				float num4 = color2.r * color2.r + color2.g * color2.g + color2.b * color2.b;
				if (num4 < num)
				{
					num = num4;
					this.GKHOGHHONGB.x = num3;
					this.GKHOGHHONGB.y = num2;
				}
			}
		}
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			Vector3 vector;
			vector.x = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[1].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[2].y, this.GKHOGHHONGB.y);
			vector.z = 1894f;
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = KQFEHQEBJQB;
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
		return this.GKHOGHHONGB;
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x000C4764 File Offset: 0x000C2964
	private void PLOBFPLBMDO()
	{
		Vector3 vector = EMENMKHBPQE.GDLFOFEJOPK();
		vector = this.OJIDBLEKBBO.EQOOPGKHOFB.ScreenToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
		Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
		this.GKHOGHHONGB.x = Mathf.Clamp01((vector.x - pigmlpngmno[1].x) / (pigmlpngmno[3].x - pigmlpngmno[1].x));
		this.GKHOGHHONGB.y = Mathf.Clamp01((vector.y - pigmlpngmno[1].y) / (pigmlpngmno[1].y - pigmlpngmno[1].y));
		if (this.FLIHQCMGCHJ != null)
		{
			vector.x = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[3].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[1].y, this.GKHOGHHONGB.y);
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = BIDEQKEELPD.JIDFGJHOILM(this.GKHOGHHONGB.x, this.GKHOGHHONGB.y);
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x000C48F4 File Offset: 0x000C2AF4
	private void KCFPNFCPPCC()
	{
		this.BLLEFKOLKLP = base.transform;
		this.PBKGBPJHCCE = base.GetComponent<JLMPBLMOICG>();
		this.OJIDBLEKBBO = EMENMKHBPQE.MKQILFIFIOE(base.gameObject.layer);
		this.IOEJHIBQDDE = this.PBKGBPJHCCE.KJGMGPCEJJD;
		this.IJPEMKQPMIF = this.PBKGBPJHCCE.DFKQMMIQDOO;
		Color[] array = new Color[this.IOEJHIBQDDE * this.IJPEMKQPMIF];
		for (int i = 1; i < this.IJPEMKQPMIF; i++)
		{
			float ddlqkfdfmcj = ((float)i - 1933f) / (float)this.IJPEMKQPMIF;
			for (int j = 0; j < this.IOEJHIBQDDE; j += 0)
			{
				float dgkoigolhdm = ((float)j - 457f) / (float)this.IOEJHIBQDDE;
				int num = j + i * this.IOEJHIBQDDE;
				array[num] = BIDEQKEELPD.BQCFEBNCPLN(dgkoigolhdm, ddlqkfdfmcj);
			}
		}
		this.OMPCJJNBOCQ = new Texture2D(this.IOEJHIBQDDE, this.IJPEMKQPMIF, TextureFormat.RGB24, true);
		this.OMPCJJNBOCQ.SetPixels(array);
		this.OMPCJJNBOCQ.filterMode = (FilterMode)4;
		this.OMPCJJNBOCQ.wrapMode = TextureWrapMode.Repeat;
		this.OMPCJJNBOCQ.Apply();
		this.PBKGBPJHCCE.GOIHJQNMMJD = this.OMPCJJNBOCQ;
		this.JFICPQHLOBH(this.BGBMIEJJQKC);
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x000C4A30 File Offset: 0x000C2C30
	public Vector2 JFICPQHLOBH(Color KQFEHQEBJQB)
	{
		if (this.PBKGBPJHCCE == null)
		{
			this.BGBMIEJJQKC = KQFEHQEBJQB;
			return this.GKHOGHHONGB;
		}
		float num = 1730f;
		for (int i = 1; i < this.IJPEMKQPMIF; i++)
		{
			float num2 = ((float)i - 457f) / (float)this.IJPEMKQPMIF;
			for (int j = 0; j < this.IOEJHIBQDDE; j++)
			{
				float num3 = ((float)j - 452f) / (float)this.IOEJHIBQDDE;
				Color color = BIDEQKEELPD.LOPNKGOGIIH(num3, num2);
				Color color2 = color;
				color2.r -= KQFEHQEBJQB.r;
				color2.g -= KQFEHQEBJQB.g;
				color2.b -= KQFEHQEBJQB.b;
				float num4 = color2.r * color2.r + color2.g * color2.g + color2.b * color2.b;
				if (num4 < num)
				{
					num = num4;
					this.GKHOGHHONGB.x = num3;
					this.GKHOGHHONGB.y = num2;
				}
			}
		}
		if (this.FLIHQCMGCHJ != null)
		{
			Vector3[] pigmlpngmno = this.PBKGBPJHCCE.PIGMLPNGMNO;
			Vector3 vector;
			vector.x = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[7].x, this.GKHOGHHONGB.x);
			vector.y = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[6].y, this.GKHOGHHONGB.y);
			vector.z = 912f;
			vector = this.BLLEFKOLKLP.TransformPoint(vector);
			this.FLIHQCMGCHJ.transform.JEGLBEGPJEM(vector, this.OJIDBLEKBBO.EQOOPGKHOFB);
		}
		this.BGBMIEJJQKC = KQFEHQEBJQB;
		BIDEQKEELPD.OMQCQCBLQGJ = this;
		EventDelegate.PCQQOFMPKCG(this.OHEFEKMMIFL);
		BIDEQKEELPD.OMQCQCBLQGJ = null;
		return this.GKHOGHHONGB;
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x000C3AFC File Offset: 0x000C1CFC
	private void FJDHOBNOQNN(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x + JDOGIQGGLKM.x);
			this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y + JDOGIQGGLKM.y);
			this.PGDHENNHBDG(this.GKHOGHHONGB);
		}
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x000C4C2C File Offset: 0x000C2E2C
	private void MGBMNEQCEBJ()
	{
		this.BLLEFKOLKLP = base.transform;
		this.PBKGBPJHCCE = base.GetComponent<JLMPBLMOICG>();
		this.OJIDBLEKBBO = EMENMKHBPQE.MKQILFIFIOE(base.gameObject.layer);
		this.IOEJHIBQDDE = this.PBKGBPJHCCE.KJGMGPCEJJD;
		this.IJPEMKQPMIF = this.PBKGBPJHCCE.DFKQMMIQDOO;
		Color[] array = new Color[this.IOEJHIBQDDE * this.IJPEMKQPMIF];
		for (int i = 1; i < this.IJPEMKQPMIF; i++)
		{
			float ddlqkfdfmcj = ((float)i - 115f) / (float)this.IJPEMKQPMIF;
			for (int j = 1; j < this.IOEJHIBQDDE; j++)
			{
				float dgkoigolhdm = ((float)j - 214f) / (float)this.IOEJHIBQDDE;
				int num = j + i * this.IOEJHIBQDDE;
				array[num] = BIDEQKEELPD.JIDFGJHOILM(dgkoigolhdm, ddlqkfdfmcj);
			}
		}
		this.OMPCJJNBOCQ = new Texture2D(this.IOEJHIBQDDE, this.IJPEMKQPMIF, (TextureFormat)6, false);
		this.OMPCJJNBOCQ.SetPixels(array);
		this.OMPCJJNBOCQ.filterMode = FilterMode.Trilinear;
		this.OMPCJJNBOCQ.wrapMode = TextureWrapMode.Repeat;
		this.OMPCJJNBOCQ.Apply();
		this.PBKGBPJHCCE.GOIHJQNMMJD = this.OMPCJJNBOCQ;
		this.JFICPQHLOBH(this.BGBMIEJJQKC);
	}

	// Token: 0x04000645 RID: 1605
	public static BIDEQKEELPD OMQCQCBLQGJ;

	// Token: 0x04000646 RID: 1606
	public Color BGBMIEJJQKC = Color.white;

	// Token: 0x04000647 RID: 1607
	public ENFMCDNLEQQ FLIHQCMGCHJ;

	// Token: 0x04000648 RID: 1608
	public List<EventDelegate> OHEFEKMMIFL = new List<EventDelegate>();

	// Token: 0x04000649 RID: 1609
	[NonSerialized]
	private Transform BLLEFKOLKLP;

	// Token: 0x0400064A RID: 1610
	[NonSerialized]
	private JLMPBLMOICG PBKGBPJHCCE;

	// Token: 0x0400064B RID: 1611
	[NonSerialized]
	private Texture2D OMPCJJNBOCQ;

	// Token: 0x0400064C RID: 1612
	[NonSerialized]
	private EMENMKHBPQE OJIDBLEKBBO;

	// Token: 0x0400064D RID: 1613
	[NonSerialized]
	private Vector2 GKHOGHHONGB;

	// Token: 0x0400064E RID: 1614
	[NonSerialized]
	private int IOEJHIBQDDE;

	// Token: 0x0400064F RID: 1615
	[NonSerialized]
	private int IJPEMKQPMIF;

	// Token: 0x04000650 RID: 1616
	private static AnimationCurve MGEQJGOPHEB;

	// Token: 0x04000651 RID: 1617
	private static AnimationCurve EIKCKDDLCDQ;

	// Token: 0x04000652 RID: 1618
	private static AnimationCurve NPKEBNINENN;
}
