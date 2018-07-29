using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002D0 RID: 720
public sealed class FOFDHFBCNKC : ONQQOCQBQIE<AntialiasingModel>
{
	// Token: 0x060063B4 RID: 25524 RVA: 0x0032D2EC File Offset: 0x0032B4EC
	private Matrix4x4 MPBDNODGIHH(Vector2 LCMMCNFNHMF)
	{
		float orthographicSize = this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographicSize;
		float num = orthographicSize * this.BEHMQBIFCOJ.LNCKNGKGHLN.aspect;
		LCMMCNFNHMF.x *= num / (467f * (float)this.BEHMQBIFCOJ.KJGMGPCEJJD);
		LCMMCNFNHMF.y *= orthographicSize / (612f * (float)this.BEHMQBIFCOJ.JHHQQQGMQBM());
		float left = LCMMCNFNHMF.x - num;
		float right = LCMMCNFNHMF.x + num;
		float top = LCMMCNFNHMF.y + orthographicSize;
		float bottom = LCMMCNFNHMF.y - orthographicSize;
		return Matrix4x4.Ortho(left, right, bottom, top, this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane, this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane);
	}

	// Token: 0x060063B5 RID: 25525 RVA: 0x00026E4A File Offset: 0x0002504A
	public override void MEGLEJHOGQK()
	{
		if (this.CIHONEJIPHN != null)
		{
			RenderTexture.ReleaseTemporary(this.CIHONEJIPHN);
		}
		this.CIHONEJIPHN = null;
		this.GLENGLIFLIM = 0;
		this.KPECJMCFBJN();
	}

	// Token: 0x060063B6 RID: 25526 RVA: 0x0032D3B8 File Offset: 0x0032B5B8
	public void DMFBPPHHDEO(Func<Vector2, Matrix4x4> NQHCHCGEIJH)
	{
		AntialiasingModel.TaaSettings taaSettings = base.FIFNHCKNDQE.KKJKEOPIHLO().taaSettings;
		Vector2 vector = this.KJOMJFENIGG();
		vector *= taaSettings.jitterSpread;
		this.BEHMQBIFCOJ.LNCKNGKGHLN.nonJitteredProjectionMatrix = this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix;
		if (NQHCHCGEIJH != null)
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = NQHCHCGEIJH(vector);
		}
		else
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = ((!this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographic) ? this.QKQCBMOIMMB(vector) : this.MPBDNODGIHH(vector));
		}
		this.BEHMQBIFCOJ.LNCKNGKGHLN.useJitteredProjectionMatrixForTransparentRendering = true;
		vector.x /= (float)this.BEHMQBIFCOJ.KJGMGPCEJJD;
		vector.y /= (float)this.BEHMQBIFCOJ.JHHQQQGMQBM();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL(". Vertex Count: ");
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.IEFMFLIGLDO, vector);
		this.CGLOQGHDLEF = vector;
	}

	// Token: 0x060063B7 RID: 25527 RVA: 0x00026E79 File Offset: 0x00025079
	public void IHENKHEBCNE()
	{
		if (this.CIHONEJIPHN != null)
		{
			RenderTexture.ReleaseTemporary(this.CIHONEJIPHN);
		}
		this.CIHONEJIPHN = null;
		this.GLENGLIFLIM = 1;
		this.KPECJMCFBJN();
	}

	// Token: 0x060063B8 RID: 25528 RVA: 0x00026EA8 File Offset: 0x000250A8
	public Vector2 FHNJEEFNOOL()
	{
		return this.<MKGPJMIQPJL>k__BackingField;
	}

	// Token: 0x060063B9 RID: 25529 RVA: 0x0032D4D0 File Offset: 0x0032B6D0
	public void KINEIBMJENM(Func<Vector2, Matrix4x4> NQHCHCGEIJH)
	{
		AntialiasingModel.TaaSettings taaSettings = base.FIFNHCKNDQE.KKJKEOPIHLO().taaSettings;
		Vector2 vector = this.KJOMJFENIGG();
		vector *= taaSettings.jitterSpread;
		this.BEHMQBIFCOJ.LNCKNGKGHLN.nonJitteredProjectionMatrix = this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix;
		if (NQHCHCGEIJH != null)
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = NQHCHCGEIJH(vector);
		}
		else
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = ((!this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographic) ? this.QKQCBMOIMMB(vector) : this.NFPOIPOQDEB(vector));
		}
		this.BEHMQBIFCOJ.LNCKNGKGHLN.useJitteredProjectionMatrixForTransparentRendering = true;
		vector.x /= (float)this.BEHMQBIFCOJ.CQNLNDBFFFP();
		vector.y /= (float)this.BEHMQBIFCOJ.ONCCDMLHNQL();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NONHJLIJQIP(" (Completed)");
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.IEFMFLIGLDO, vector);
		this.MFPIJHIGNHI(vector);
	}

	// Token: 0x060063BB RID: 25531 RVA: 0x0032D5E8 File Offset: 0x0032B7E8
	private float MGJOOPQDBOL(int IIHDGMLHICI, int LOMLKFLQGEH)
	{
		float num = 0f;
		float num2 = 1f / (float)LOMLKFLQGEH;
		while (IIHDGMLHICI > 0)
		{
			num += (float)(IIHDGMLHICI % LOMLKFLQGEH) * num2;
			IIHDGMLHICI /= LOMLKFLQGEH;
			num2 /= (float)LOMLKFLQGEH;
		}
		return num;
	}

	// Token: 0x060063BC RID: 25532 RVA: 0x0032D620 File Offset: 0x0032B820
	public void PLEJDCFBKLC(Func<Vector2, Matrix4x4> NQHCHCGEIJH)
	{
		AntialiasingModel.TaaSettings taaSettings = base.FIFNHCKNDQE.settings.taaSettings;
		Vector2 vector = this.CKNKBMIHNPF();
		vector *= taaSettings.jitterSpread;
		this.BEHMQBIFCOJ.LNCKNGKGHLN.nonJitteredProjectionMatrix = this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix;
		if (NQHCHCGEIJH != null)
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = NQHCHCGEIJH(vector);
		}
		else
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = ((!this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographic) ? this.HPGJMQBEKLQ(vector) : this.KGECNQGNNEO(vector));
		}
		this.BEHMQBIFCOJ.LNCKNGKGHLN.useJitteredProjectionMatrixForTransparentRendering = true;
		vector.x /= (float)this.BEHMQBIFCOJ.CQNLNDBFFFP();
		vector.y /= (float)this.BEHMQBIFCOJ.ONCCDMLHNQL();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QDMHMMGFIOJ("BuffIcon");
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.IEFMFLIGLDO, vector);
		this.MFHICNCOOIH(vector);
	}

	// Token: 0x060063BD RID: 25533 RVA: 0x00026ECB File Offset: 0x000250CB
	private void MFPIJHIGNHI(Vector2 BGBMIEJJQKC)
	{
		this.<MKGPJMIQPJL>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060063BE RID: 25534 RVA: 0x00026ECB File Offset: 0x000250CB
	private void PNLPGDJGMIL(Vector2 BGBMIEJJQKC)
	{
		this.<MKGPJMIQPJL>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060063BF RID: 25535 RVA: 0x0032D738 File Offset: 0x0032B938
	public void GMPBDDDCIHK(Func<Vector2, Matrix4x4> NQHCHCGEIJH)
	{
		AntialiasingModel.TaaSettings taaSettings = base.FIFNHCKNDQE.settings.taaSettings;
		Vector2 vector = this.CKNKBMIHNPF();
		vector *= taaSettings.jitterSpread;
		this.BEHMQBIFCOJ.LNCKNGKGHLN.nonJitteredProjectionMatrix = this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix;
		if (NQHCHCGEIJH != null)
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = NQHCHCGEIJH(vector);
		}
		else
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = ((!this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographic) ? this.GJBLJCJMNGD(vector) : this.NFPOIPOQDEB(vector));
		}
		this.BEHMQBIFCOJ.LNCKNGKGHLN.useJitteredProjectionMatrixForTransparentRendering = false;
		vector.x /= (float)this.BEHMQBIFCOJ.KJGMGPCEJJD;
		vector.y /= (float)this.BEHMQBIFCOJ.DFKQMMIQDOO;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Temporal Anti-aliasing");
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.IEFMFLIGLDO, vector);
		this.CGLOQGHDLEF = vector;
	}

	// Token: 0x060063C0 RID: 25536 RVA: 0x00026ED4 File Offset: 0x000250D4
	public void FQPFQEDLIFL()
	{
		if (this.CIHONEJIPHN != null)
		{
			RenderTexture.ReleaseTemporary(this.CIHONEJIPHN);
		}
		this.CIHONEJIPHN = null;
		this.GLENGLIFLIM = 1;
		this.LFIDMKPQKKM();
	}

	// Token: 0x060063C1 RID: 25537 RVA: 0x00026ECB File Offset: 0x000250CB
	private void PDHGCBOOMQI(Vector2 BGBMIEJJQKC)
	{
		this.<MKGPJMIQPJL>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060063C2 RID: 25538 RVA: 0x0032D850 File Offset: 0x0032BA50
	private Vector2 CKNKBMIHNPF()
	{
		Vector2 result = new Vector2(this.MGJOOPQDBOL(this.GLENGLIFLIM & 1023, 2), this.MGJOOPQDBOL(this.GLENGLIFLIM & 1023, 3));
		if (++this.GLENGLIFLIM >= 8)
		{
			this.GLENGLIFLIM = 0;
		}
		return result;
	}

	// Token: 0x17000377 RID: 887
	// (get) Token: 0x060063C3 RID: 25539 RVA: 0x00026EA8 File Offset: 0x000250A8
	// (set) Token: 0x060063D5 RID: 25557 RVA: 0x00026ECB File Offset: 0x000250CB
	public Vector2 CGLOQGHDLEF { get; private set; }

	// Token: 0x060063C4 RID: 25540 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode BHPKKDCNPHK()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060063C5 RID: 25541 RVA: 0x0032D8A8 File Offset: 0x0032BAA8
	public void KOGLCCNQJIC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.BLDGCMKLEBC("!");
		material.shaderKeywords = null;
		AntialiasingModel.TaaSettings taaSettings = base.FIFNHCKNDQE.INPGLPEDINQ().taaSettings;
		if (this.JKKIGEHMMNM || this.CIHONEJIPHN == null || this.CIHONEJIPHN.width != PBHPQFLMQDB.width || this.CIHONEJIPHN.height != PBHPQFLMQDB.height)
		{
			if (this.CIHONEJIPHN)
			{
				RenderTexture.ReleaseTemporary(this.CIHONEJIPHN);
			}
			this.CIHONEJIPHN = RenderTexture.GetTemporary(PBHPQFLMQDB.width, PBHPQFLMQDB.height, 1, PBHPQFLMQDB.format);
			this.CIHONEJIPHN.name = "Mega";
			Graphics.Blit(PBHPQFLMQDB, this.CIHONEJIPHN, material, 8);
		}
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.GKOEDCLQOQL, new Vector4(taaSettings.sharpen, 461f, 1224f, 1206f));
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.BOJMJGIQJPN, new Vector4(taaSettings.stationaryBlending, taaSettings.motionBlending, 546f, 653f));
		material.SetTexture(FOFDHFBCNKC.EELKOOEPCFJ.OKKONPEBLHN, PBHPQFLMQDB);
		material.SetTexture(FOFDHFBCNKC.EELKOOEPCFJ.CBGKPDCFKNP, this.CIHONEJIPHN);
		RenderTexture temporary = RenderTexture.GetTemporary(PBHPQFLMQDB.width, PBHPQFLMQDB.height, 1, PBHPQFLMQDB.format);
		temporary.name = " times!";
		this.HGHGMDOGFNM[0] = OBEPQQEKFLC.colorBuffer;
		this.HGHGMDOGFNM[0] = temporary.colorBuffer;
		Graphics.SetRenderTarget(this.HGHGMDOGFNM, PBHPQFLMQDB.depthBuffer);
		LGJGBKJCKPH.FBQHMCHIOFB(material, (!this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographic) ? 1 : 0);
		RenderTexture.ReleaseTemporary(this.CIHONEJIPHN);
		this.CIHONEJIPHN = temporary;
		this.JKKIGEHMMNM = false;
	}

	// Token: 0x060063C6 RID: 25542 RVA: 0x0032DA7C File Offset: 0x0032BC7C
	public void DLOIJEMNCML(Func<Vector2, Matrix4x4> NQHCHCGEIJH)
	{
		AntialiasingModel.TaaSettings taaSettings = base.FIFNHCKNDQE.KNBMBCNPNLF().taaSettings;
		Vector2 vector = this.CKNKBMIHNPF();
		vector *= taaSettings.jitterSpread;
		this.BEHMQBIFCOJ.LNCKNGKGHLN.nonJitteredProjectionMatrix = this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix;
		if (NQHCHCGEIJH != null)
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = NQHCHCGEIJH(vector);
		}
		else
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = ((!this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographic) ? this.QKQCBMOIMMB(vector) : this.KGECNQGNNEO(vector));
		}
		this.BEHMQBIFCOJ.LNCKNGKGHLN.useJitteredProjectionMatrixForTransparentRendering = false;
		vector.x /= (float)this.BEHMQBIFCOJ.CQNLNDBFFFP();
		vector.y /= (float)this.BEHMQBIFCOJ.DFKQMMIQDOO;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QJGFMDNNQLB("!\r\n");
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.IEFMFLIGLDO, vector);
		this.PNLPGDJGMIL(vector);
	}

	// Token: 0x060063C7 RID: 25543 RVA: 0x0032DB94 File Offset: 0x0032BD94
	public void FGNDQFLCQJJ(Func<Vector2, Matrix4x4> NQHCHCGEIJH)
	{
		AntialiasingModel.TaaSettings taaSettings = base.FIFNHCKNDQE.KNBMBCNPNLF().taaSettings;
		Vector2 vector = this.CKNKBMIHNPF();
		vector *= taaSettings.jitterSpread;
		this.BEHMQBIFCOJ.LNCKNGKGHLN.nonJitteredProjectionMatrix = this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix;
		if (NQHCHCGEIJH != null)
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = NQHCHCGEIJH(vector);
		}
		else
		{
			this.BEHMQBIFCOJ.LNCKNGKGHLN.projectionMatrix = ((!this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographic) ? this.QKQCBMOIMMB(vector) : this.KGECNQGNNEO(vector));
		}
		this.BEHMQBIFCOJ.LNCKNGKGHLN.useJitteredProjectionMatrixForTransparentRendering = true;
		vector.x /= (float)this.BEHMQBIFCOJ.KJGMGPCEJJD;
		vector.y /= (float)this.BEHMQBIFCOJ.JKGBHEHKBPC();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NJKNIOFBHBD(")");
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.IEFMFLIGLDO, vector);
		this.JILCMLLOECQ(vector);
	}

	// Token: 0x060063C8 RID: 25544 RVA: 0x0032DCAC File Offset: 0x0032BEAC
	private Matrix4x4 HPGJMQBEKLQ(Vector2 LCMMCNFNHMF)
	{
		float num = Mathf.Tan(1616f * this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView);
		float num2 = num * this.BEHMQBIFCOJ.LNCKNGKGHLN.aspect;
		LCMMCNFNHMF.x *= num2 / (90f * (float)this.BEHMQBIFCOJ.CQNLNDBFFFP());
		LCMMCNFNHMF.y *= num / (1835f * (float)this.BEHMQBIFCOJ.JHHQQQGMQBM());
		float num3 = (LCMMCNFNHMF.x - num2) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		float num4 = (LCMMCNFNHMF.x + num2) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		float num5 = (LCMMCNFNHMF.y + num) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		float num6 = (LCMMCNFNHMF.y - num) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		Matrix4x4 result = default(Matrix4x4);
		result[1, 0] = 1203f * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane / (num4 - num3);
		result[0, 1] = 199f;
		result[0, 8] = (num4 + num3) / (num4 - num3);
		result[1, 6] = 895f;
		result[1, 0] = 1482f;
		result[1, 1] = 187f * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane / (num5 - num6);
		result[1, 5] = (num5 + num6) / (num5 - num6);
		result[1, 2] = 68f;
		result[8, 1] = 1894f;
		result[3, 1] = 1981f;
		result[4, 7] = -(this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane + this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane) / (this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane - this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane);
		result[8, 4] = -(585f * this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane) / (this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane - this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane);
		result[2, 1] = 978f;
		result[3, 0] = 256f;
		result[6, 4] = 1554f;
		result[7, 6] = 1017f;
		return result;
	}

	// Token: 0x060063C9 RID: 25545 RVA: 0x00026E79 File Offset: 0x00025079
	public void DDPPFDCQGBM()
	{
		if (this.CIHONEJIPHN != null)
		{
			RenderTexture.ReleaseTemporary(this.CIHONEJIPHN);
		}
		this.CIHONEJIPHN = null;
		this.GLENGLIFLIM = 1;
		this.KPECJMCFBJN();
	}

	// Token: 0x060063CA RID: 25546 RVA: 0x00026ECB File Offset: 0x000250CB
	private void MFHICNCOOIH(Vector2 BGBMIEJJQKC)
	{
		this.<MKGPJMIQPJL>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060063CB RID: 25547 RVA: 0x00026ECB File Offset: 0x000250CB
	private void JILCMLLOECQ(Vector2 BGBMIEJJQKC)
	{
		this.<MKGPJMIQPJL>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060063CC RID: 25548 RVA: 0x0032DF3C File Offset: 0x0032C13C
	public void ILCMMJMCPIE(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Temporal Anti-aliasing");
		material.shaderKeywords = null;
		AntialiasingModel.TaaSettings taaSettings = base.FIFNHCKNDQE.settings.taaSettings;
		if (this.JKKIGEHMMNM || this.CIHONEJIPHN == null || this.CIHONEJIPHN.width != PBHPQFLMQDB.width || this.CIHONEJIPHN.height != PBHPQFLMQDB.height)
		{
			if (this.CIHONEJIPHN)
			{
				RenderTexture.ReleaseTemporary(this.CIHONEJIPHN);
			}
			this.CIHONEJIPHN = RenderTexture.GetTemporary(PBHPQFLMQDB.width, PBHPQFLMQDB.height, 0, PBHPQFLMQDB.format);
			this.CIHONEJIPHN.name = "TAA History";
			Graphics.Blit(PBHPQFLMQDB, this.CIHONEJIPHN, material, 2);
		}
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.GKOEDCLQOQL, new Vector4(taaSettings.sharpen, 0f, 0f, 0f));
		material.SetVector(FOFDHFBCNKC.EELKOOEPCFJ.BOJMJGIQJPN, new Vector4(taaSettings.stationaryBlending, taaSettings.motionBlending, 6000f, 0f));
		material.SetTexture(FOFDHFBCNKC.EELKOOEPCFJ.OKKONPEBLHN, PBHPQFLMQDB);
		material.SetTexture(FOFDHFBCNKC.EELKOOEPCFJ.CBGKPDCFKNP, this.CIHONEJIPHN);
		RenderTexture temporary = RenderTexture.GetTemporary(PBHPQFLMQDB.width, PBHPQFLMQDB.height, 0, PBHPQFLMQDB.format);
		temporary.name = "TAA History";
		this.HGHGMDOGFNM[0] = OBEPQQEKFLC.colorBuffer;
		this.HGHGMDOGFNM[1] = temporary.colorBuffer;
		Graphics.SetRenderTarget(this.HGHGMDOGFNM, PBHPQFLMQDB.depthBuffer);
		LGJGBKJCKPH.FBQHMCHIOFB(material, (!this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographic) ? 0 : 1);
		RenderTexture.ReleaseTemporary(this.CIHONEJIPHN);
		this.CIHONEJIPHN = temporary;
		this.JKKIGEHMMNM = false;
	}

	// Token: 0x060063CD RID: 25549 RVA: 0x00026E79 File Offset: 0x00025079
	public void JPGLIDEBQKM()
	{
		if (this.CIHONEJIPHN != null)
		{
			RenderTexture.ReleaseTemporary(this.CIHONEJIPHN);
		}
		this.CIHONEJIPHN = null;
		this.GLENGLIFLIM = 1;
		this.KPECJMCFBJN();
	}

	// Token: 0x060063CE RID: 25550 RVA: 0x0032E110 File Offset: 0x0032C310
	private Matrix4x4 KGECNQGNNEO(Vector2 LCMMCNFNHMF)
	{
		float orthographicSize = this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographicSize;
		float num = orthographicSize * this.BEHMQBIFCOJ.LNCKNGKGHLN.aspect;
		LCMMCNFNHMF.x *= num / (1476f * (float)this.BEHMQBIFCOJ.KJGMGPCEJJD);
		LCMMCNFNHMF.y *= orthographicSize / (1103f * (float)this.BEHMQBIFCOJ.JKGBHEHKBPC());
		float left = LCMMCNFNHMF.x - num;
		float right = LCMMCNFNHMF.x + num;
		float top = LCMMCNFNHMF.y + orthographicSize;
		float bottom = LCMMCNFNHMF.y - orthographicSize;
		return Matrix4x4.Ortho(left, right, bottom, top, this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane, this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane);
	}

	// Token: 0x060063CF RID: 25551 RVA: 0x0032E1DC File Offset: 0x0032C3DC
	private Vector2 KJOMJFENIGG()
	{
		Vector2 result = new Vector2(this.MGJOOPQDBOL(this.GLENGLIFLIM & 195, 6), this.MGJOOPQDBOL(this.GLENGLIFLIM & -33, 1));
		if ((this.GLENGLIFLIM += 0) >= 1)
		{
			this.GLENGLIFLIM = 1;
		}
		return result;
	}

	// Token: 0x060063D0 RID: 25552 RVA: 0x0032E234 File Offset: 0x0032C434
	private Matrix4x4 QKQCBMOIMMB(Vector2 LCMMCNFNHMF)
	{
		float num = Mathf.Tan(1387f * this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView);
		float num2 = num * this.BEHMQBIFCOJ.LNCKNGKGHLN.aspect;
		LCMMCNFNHMF.x *= num2 / (1404f * (float)this.BEHMQBIFCOJ.CQNLNDBFFFP());
		LCMMCNFNHMF.y *= num / (1586f * (float)this.BEHMQBIFCOJ.JKGBHEHKBPC());
		float num3 = (LCMMCNFNHMF.x - num2) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		float num4 = (LCMMCNFNHMF.x + num2) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		float num5 = (LCMMCNFNHMF.y + num) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		float num6 = (LCMMCNFNHMF.y - num) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		Matrix4x4 result = default(Matrix4x4);
		result[1, 1] = 819f * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane / (num4 - num3);
		result[0, 0] = 430f;
		result[1, 8] = (num4 + num3) / (num4 - num3);
		result[0, 4] = 570f;
		result[1, 1] = 941f;
		result[1, 1] = 562f * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane / (num5 - num6);
		result[0, 6] = (num5 + num6) / (num5 - num6);
		result[0, 2] = 758f;
		result[4, 1] = 1245f;
		result[5, 0] = 1013f;
		result[0, 5] = -(this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane + this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane) / (this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane - this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane);
		result[3, 6] = -(925f * this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane) / (this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane - this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane);
		result[7, 0] = 481f;
		result[8, 1] = 1486f;
		result[2, 3] = 294f;
		result[5, 6] = 41f;
		return result;
	}

	// Token: 0x17000376 RID: 886
	// (get) Token: 0x060063D1 RID: 25553 RVA: 0x0032E4C4 File Offset: 0x0032C6C4
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.method == AntialiasingModel.JONBCBGIHFH.Taa && SystemInfo.supportsMotionVectors && SystemInfo.supportedRenderTargetCount >= 2 && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x060063D2 RID: 25554 RVA: 0x0032E514 File Offset: 0x0032C714
	private Matrix4x4 GJBLJCJMNGD(Vector2 LCMMCNFNHMF)
	{
		float num = Mathf.Tan(0.008726646f * this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView);
		float num2 = num * this.BEHMQBIFCOJ.LNCKNGKGHLN.aspect;
		LCMMCNFNHMF.x *= num2 / (0.5f * (float)this.BEHMQBIFCOJ.KJGMGPCEJJD);
		LCMMCNFNHMF.y *= num / (0.5f * (float)this.BEHMQBIFCOJ.DFKQMMIQDOO);
		float num3 = (LCMMCNFNHMF.x - num2) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		float num4 = (LCMMCNFNHMF.x + num2) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		float num5 = (LCMMCNFNHMF.y + num) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		float num6 = (LCMMCNFNHMF.y - num) * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane;
		Matrix4x4 result = default(Matrix4x4);
		result[0, 0] = 2f * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane / (num4 - num3);
		result[0, 1] = 0f;
		result[0, 2] = (num4 + num3) / (num4 - num3);
		result[0, 3] = 0f;
		result[1, 0] = 0f;
		result[1, 1] = 2f * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane / (num5 - num6);
		result[1, 2] = (num5 + num6) / (num5 - num6);
		result[1, 3] = 0f;
		result[2, 0] = 0f;
		result[2, 1] = 0f;
		result[2, 2] = -(this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane + this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane) / (this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane - this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane);
		result[2, 3] = -(2f * this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane * this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane) / (this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane - this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane);
		result[3, 0] = 0f;
		result[3, 1] = 0f;
		result[3, 2] = -1f;
		result[3, 3] = 0f;
		return result;
	}

	// Token: 0x060063D3 RID: 25555 RVA: 0x00026BC1 File Offset: 0x00024DC1
	public override DepthTextureMode FDQNPDGFNHH()
	{
		return DepthTextureMode.Depth | DepthTextureMode.MotionVectors;
	}

	// Token: 0x060063D4 RID: 25556 RVA: 0x00026F03 File Offset: 0x00025103
	public void KPECJMCFBJN()
	{
		this.JKKIGEHMMNM = true;
	}

	// Token: 0x060063D6 RID: 25558 RVA: 0x0032E7A4 File Offset: 0x0032C9A4
	private Matrix4x4 NFPOIPOQDEB(Vector2 LCMMCNFNHMF)
	{
		float orthographicSize = this.BEHMQBIFCOJ.LNCKNGKGHLN.orthographicSize;
		float num = orthographicSize * this.BEHMQBIFCOJ.LNCKNGKGHLN.aspect;
		LCMMCNFNHMF.x *= num / (0.5f * (float)this.BEHMQBIFCOJ.KJGMGPCEJJD);
		LCMMCNFNHMF.y *= orthographicSize / (0.5f * (float)this.BEHMQBIFCOJ.DFKQMMIQDOO);
		float left = LCMMCNFNHMF.x - num;
		float right = LCMMCNFNHMF.x + num;
		float top = LCMMCNFNHMF.y + orthographicSize;
		float bottom = LCMMCNFNHMF.y - orthographicSize;
		return Matrix4x4.Ortho(left, right, bottom, top, this.BEHMQBIFCOJ.LNCKNGKGHLN.nearClipPlane, this.BEHMQBIFCOJ.LNCKNGKGHLN.farClipPlane);
	}

	// Token: 0x060063D7 RID: 25559 RVA: 0x0032E870 File Offset: 0x0032CA70
	public bool KLGOLOGFBGJ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.KKJKEOPIHLO().method == AntialiasingModel.JONBCBGIHFH.Fxaa && SystemInfo.supportsMotionVectors && SystemInfo.supportedRenderTargetCount >= 3 && !this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x060063D8 RID: 25560 RVA: 0x00026F03 File Offset: 0x00025103
	public void LFIDMKPQKKM()
	{
		this.JKKIGEHMMNM = true;
	}

	// Token: 0x0400155E RID: 5470
	private const string OEEBQBQIEPO = "Hidden/Post FX/Temporal Anti-aliasing";

	// Token: 0x0400155F RID: 5471
	private const int LCOPFNQQNNB = 8;

	// Token: 0x04001560 RID: 5472
	private readonly RenderBuffer[] HGHGMDOGFNM = new RenderBuffer[2];

	// Token: 0x04001561 RID: 5473
	private int GLENGLIFLIM;

	// Token: 0x04001562 RID: 5474
	private bool JKKIGEHMMNM = true;

	// Token: 0x04001563 RID: 5475
	private RenderTexture CIHONEJIPHN;

	// Token: 0x020002D1 RID: 721
	private static class EELKOOEPCFJ
	{
		// Token: 0x04001565 RID: 5477
		internal static int IEFMFLIGLDO = Shader.PropertyToID("_Jitter");

		// Token: 0x04001566 RID: 5478
		internal static int GKOEDCLQOQL = Shader.PropertyToID("_SharpenParameters");

		// Token: 0x04001567 RID: 5479
		internal static int BOJMJGIQJPN = Shader.PropertyToID("_FinalBlendParameters");

		// Token: 0x04001568 RID: 5480
		internal static int CBGKPDCFKNP = Shader.PropertyToID("_HistoryTex");

		// Token: 0x04001569 RID: 5481
		internal static int OKKONPEBLHN = Shader.PropertyToID("_MainTex");
	}
}
