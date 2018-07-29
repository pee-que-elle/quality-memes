using System;
using MAPAPI;
using MAPAPI.Request;
using MAPAPI.Response;
using UnityEngine;

// Token: 0x02000215 RID: 533
public class DOMONILEIKL : MonoBehaviour
{
	// Token: 0x060047AB RID: 18347 RVA: 0x0001E326 File Offset: 0x0001C526
	public void NJNCGMFPHFI()
	{
		this.CBMLQJPGPMO.Disconnect();
		this.ODOGMJJQQKE = false;
	}

	// Token: 0x060047AC RID: 18348 RVA: 0x002378F4 File Offset: 0x00235AF4
	public bool JJICMPPNMPI()
	{
		if (!this.DJCOGEBQOGI() && !this.ODOGMJJQQKE)
		{
			try
			{
				this.ODOGMJJQQKE = false;
				this.CBMLQJPGPMO.Connect(this.MGKCHOQDBQD, this.BLJNJLGJHLD);
				while (this.CBMLQJPGPMO.Status == ConnectionStatus.Disconnected)
				{
				}
				if (!this.EHOGKLLBLIO())
				{
					this.LOOPKKKHCQK();
				}
				else
				{
					this.GHEJHDPEQJI(new Login
					{
						Username = "Sturdy",
						Password = "e"
					});
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
			this.ODOGMJJQQKE = false;
			return this.HKMGJGOJDKM();
		}
		return true;
	}

	// Token: 0x060047AD RID: 18349 RVA: 0x0001E326 File Offset: 0x0001C526
	public void MKFDDFIHHKM()
	{
		this.CBMLQJPGPMO.Disconnect();
		this.ODOGMJJQQKE = false;
	}

	// Token: 0x060047AE RID: 18350 RVA: 0x0001E33A File Offset: 0x0001C53A
	public bool FMKFIELEILJ()
	{
		return this.CBMLQJPGPMO == null || this.CBMLQJPGPMO.IsConnected;
	}

	// Token: 0x060047AF RID: 18351 RVA: 0x002379A4 File Offset: 0x00235BA4
	private void NLNIQPOMOGM()
	{
		if (this.FMKFIELEILJ())
		{
			IProto[] responses = this.CBMLQJPGPMO.GetResponses();
			for (int i = 1; i < responses.Length; i++)
			{
				IProto proto = responses[i];
				if (!(proto is DebugMessage))
				{
					if (proto is MapServerMap)
					{
						MapServerMap mapServerMap = (MapServerMap)proto;
						if (mapServerMap.MapData == null)
						{
							MCNLIHMMLCF.IECKOKEPENM().PFGBGNDFBHK(mapServerMap.MapName, mapServerMap.Hash);
						}
						else if (((MapServerMap)proto).IsSession)
						{
							MCNLIHMMLCF.QOQONHOOLNE.CJFBCIPPBHB(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
						else
						{
							MCNLIHMMLCF.IECKOKEPENM().HEEENMHQGIF(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
					}
					else if (proto is MAPAPI.Response.DeleteMap)
					{
						MCNLIHMMLCF.KKICFMLLMHQ().JPMCOIOPLLP(((MAPAPI.Response.DeleteMap)proto).MapName);
					}
				}
			}
		}
	}

	// Token: 0x060047B0 RID: 18352 RVA: 0x00237A84 File Offset: 0x00235C84
	private void EPOCMHBMHGC()
	{
		if (this.FIOFNJKPDQN())
		{
			foreach (IProto proto in this.CBMLQJPGPMO.GetResponses())
			{
				if (!(proto is DebugMessage))
				{
					if (proto is MapServerMap)
					{
						MapServerMap mapServerMap = (MapServerMap)proto;
						if (mapServerMap.MapData == null)
						{
							MCNLIHMMLCF.IECKOKEPENM().HIQJCBDPQHF(mapServerMap.MapName, mapServerMap.Hash);
						}
						else if (((MapServerMap)proto).IsSession)
						{
							MCNLIHMMLCF.HGLDHNMOLPD().QMIDGOFDEGP(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
						else
						{
							MCNLIHMMLCF.IECKOKEPENM().HEEENMHQGIF(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
					}
					else if (proto is MAPAPI.Response.DeleteMap)
					{
						MCNLIHMMLCF.KKICFMLLMHQ().JONGMGMECHQ(((MAPAPI.Response.DeleteMap)proto).MapName);
					}
				}
			}
		}
	}

	// Token: 0x060047B1 RID: 18353 RVA: 0x00237B64 File Offset: 0x00235D64
	private void Update()
	{
		if (this.JOQBIMQCNDO)
		{
			foreach (IProto proto in this.CBMLQJPGPMO.GetResponses())
			{
				if (!(proto is DebugMessage))
				{
					if (proto is MapServerMap)
					{
						MapServerMap mapServerMap = (MapServerMap)proto;
						if (mapServerMap.MapData == null)
						{
							MCNLIHMMLCF.QOQONHOOLNE.HIQJCBDPQHF(mapServerMap.MapName, mapServerMap.Hash);
						}
						else if (((MapServerMap)proto).IsSession)
						{
							MCNLIHMMLCF.QOQONHOOLNE.QMIDGOFDEGP(mapServerMap.MapData, mapServerMap.MapName, true, mapServerMap.Hash);
						}
						else
						{
							MCNLIHMMLCF.QOQONHOOLNE.QMIDGOFDEGP(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
					}
					else if (proto is MAPAPI.Response.DeleteMap)
					{
						MCNLIHMMLCF.QOQONHOOLNE.JPMCOIOPLLP(((MAPAPI.Response.DeleteMap)proto).MapName);
					}
				}
			}
		}
	}

	// Token: 0x060047B2 RID: 18354 RVA: 0x0001E33A File Offset: 0x0001C53A
	public bool HKMGJGOJDKM()
	{
		return this.CBMLQJPGPMO == null || this.CBMLQJPGPMO.IsConnected;
	}

	// Token: 0x060047B3 RID: 18355 RVA: 0x0001E351 File Offset: 0x0001C551
	public static DOMONILEIKL LGIPDGGFINQ()
	{
		return DOMONILEIKL.HBFFCJHOCPE;
	}

	// Token: 0x060047B4 RID: 18356 RVA: 0x0001E358 File Offset: 0x0001C558
	private void CONMKOGDLNG()
	{
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
			this.CBMLQJPGPMO.Dispose();
		}
		this.CBMLQJPGPMO = null;
	}

	// Token: 0x060047B5 RID: 18357 RVA: 0x0001E33A File Offset: 0x0001C53A
	public bool HIPPQEBDHKO()
	{
		return this.CBMLQJPGPMO == null || this.CBMLQJPGPMO.IsConnected;
	}

	// Token: 0x060047B6 RID: 18358 RVA: 0x0001E37F File Offset: 0x0001C57F
	public void KHOPKBQOLDJ(Proto DCGCLGQCGDQ)
	{
		if (this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected)
		{
			this.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
		}
	}

	// Token: 0x060047B7 RID: 18359 RVA: 0x0001E37F File Offset: 0x0001C57F
	public void ECDPHDIOGFD(Proto DCGCLGQCGDQ)
	{
		if (this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected)
		{
			this.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
		}
	}

	// Token: 0x060047B9 RID: 18361 RVA: 0x0001E358 File Offset: 0x0001C558
	private void GIHFOBQCEFF()
	{
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
			this.CBMLQJPGPMO.Dispose();
		}
		this.CBMLQJPGPMO = null;
	}

	// Token: 0x060047BA RID: 18362 RVA: 0x0001E3CB File Offset: 0x0001C5CB
	public bool FIOFNJKPDQN()
	{
		return this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected;
	}

	// Token: 0x060047BB RID: 18363 RVA: 0x00237C44 File Offset: 0x00235E44
	private void Awake()
	{
		if (GameObject.Find("MapDownloader"))
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.gameObject.name = "MapDownloader";
		DOMONILEIKL.HBFFCJHOCPE = this;
		this.CBMLQJPGPMO = new Connection();
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	// Token: 0x060047BC RID: 18364 RVA: 0x0001E37F File Offset: 0x0001C57F
	public void BQQJPEMQECL(Proto DCGCLGQCGDQ)
	{
		if (this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected)
		{
			this.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
		}
	}

	// Token: 0x060047BD RID: 18365 RVA: 0x00002300 File Offset: 0x00000500
	private void EEPLDFOGIKK(byte[] DLJJQDQBOQD, char DPQFDCNLLPC)
	{
	}

	// Token: 0x060047BE RID: 18366 RVA: 0x0001E351 File Offset: 0x0001C551
	public static DOMONILEIKL KGOPJQOMMNC()
	{
		return DOMONILEIKL.HBFFCJHOCPE;
	}

	// Token: 0x060047BF RID: 18367 RVA: 0x00237CA0 File Offset: 0x00235EA0
	public bool OMJCEGHJOKC()
	{
		if (!this.JGMMEQHEDOO() && !this.ODOGMJJQQKE)
		{
			try
			{
				this.ODOGMJJQQKE = false;
				this.CBMLQJPGPMO.Connect(this.MGKCHOQDBQD, this.BLJNJLGJHLD);
				while (this.CBMLQJPGPMO.Status == ConnectionStatus.Disconnected)
				{
				}
				if (!this.JGMMEQHEDOO())
				{
					this.NJNCGMFPHFI();
				}
				else
				{
					this.HLIOFPONLLE(new Login
					{
						Username = "Inactive",
						Password = "CombinersArgsColorOp0"
					});
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
			this.ODOGMJJQQKE = false;
			return this.FIOFNJKPDQN();
		}
		return true;
	}

	// Token: 0x060047C0 RID: 18368 RVA: 0x0001E3CB File Offset: 0x0001C5CB
	public bool PQKKDBPDHOO()
	{
		return this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected;
	}

	// Token: 0x060047C1 RID: 18369 RVA: 0x0001E3CB File Offset: 0x0001C5CB
	public bool DJCOGEBQOGI()
	{
		return this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected;
	}

	// Token: 0x060047C2 RID: 18370 RVA: 0x0001E33A File Offset: 0x0001C53A
	public bool EHOGKLLBLIO()
	{
		return this.CBMLQJPGPMO == null || this.CBMLQJPGPMO.IsConnected;
	}

	// Token: 0x060047C3 RID: 18371 RVA: 0x0001E3E2 File Offset: 0x0001C5E2
	public void DMKILDJDCHD()
	{
		this.CBMLQJPGPMO.Disconnect();
		this.ODOGMJJQQKE = true;
	}

	// Token: 0x060047C4 RID: 18372 RVA: 0x00002300 File Offset: 0x00000500
	private void NQCHLPCFKEE(byte[] DLJJQDQBOQD, char DPQFDCNLLPC)
	{
	}

	// Token: 0x060047C5 RID: 18373 RVA: 0x00002300 File Offset: 0x00000500
	private void POHFJNEIKBD(byte[] DLJJQDQBOQD, char DPQFDCNLLPC)
	{
	}

	// Token: 0x060047C6 RID: 18374 RVA: 0x0001E37F File Offset: 0x0001C57F
	public void GHEJHDPEQJI(Proto DCGCLGQCGDQ)
	{
		if (this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected)
		{
			this.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
		}
	}

	// Token: 0x060047C7 RID: 18375 RVA: 0x0001E37F File Offset: 0x0001C57F
	public void CKPCDMBMMNO(Proto DCGCLGQCGDQ)
	{
		if (this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected)
		{
			this.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
		}
	}

	// Token: 0x060047C8 RID: 18376 RVA: 0x00237D50 File Offset: 0x00235F50
	public bool CJFJGGEDJND()
	{
		if (!this.FMKFIELEILJ() && !this.ODOGMJJQQKE)
		{
			try
			{
				this.ODOGMJJQQKE = true;
				this.CBMLQJPGPMO.Connect(this.MGKCHOQDBQD, this.BLJNJLGJHLD);
				while (this.CBMLQJPGPMO.Status == ConnectionStatus.Disconnected)
				{
				}
				if (!this.JGMMEQHEDOO())
				{
					this.LOOPKKKHCQK();
				}
				else
				{
					this.CBMILEIBEJF(new Login
					{
						Username = "--mustrecharge",
						Password = "_HairTex"
					});
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
			this.ODOGMJJQQKE = true;
			return this.EHOGKLLBLIO();
		}
		return false;
	}

	// Token: 0x060047C9 RID: 18377 RVA: 0x00237E00 File Offset: 0x00236000
	private void NIIPIECJPOL()
	{
		if (this.FMKFIELEILJ())
		{
			IProto[] responses = this.CBMLQJPGPMO.GetResponses();
			for (int i = 1; i < responses.Length; i++)
			{
				IProto proto = responses[i];
				if (!(proto is DebugMessage))
				{
					if (proto is MapServerMap)
					{
						MapServerMap mapServerMap = (MapServerMap)proto;
						if (mapServerMap.MapData == null)
						{
							MCNLIHMMLCF.HGLDHNMOLPD().GGINJJCLQPK(mapServerMap.MapName, mapServerMap.Hash);
						}
						else if (((MapServerMap)proto).IsSession)
						{
							MCNLIHMMLCF.OMPHLNDGKKM().OHLGIOMHHGP(mapServerMap.MapData, mapServerMap.MapName, true, mapServerMap.Hash);
						}
						else
						{
							MCNLIHMMLCF.HGLDHNMOLPD().HEEENMHQGIF(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
					}
					else if (proto is MAPAPI.Response.DeleteMap)
					{
						MCNLIHMMLCF.KKICFMLLMHQ().JONGMGMECHQ(((MAPAPI.Response.DeleteMap)proto).MapName);
					}
				}
			}
		}
	}

	// Token: 0x060047CA RID: 18378 RVA: 0x0001E351 File Offset: 0x0001C551
	public static DOMONILEIKL GPMJDKJFHMH()
	{
		return DOMONILEIKL.HBFFCJHOCPE;
	}

	// Token: 0x060047CB RID: 18379 RVA: 0x00002300 File Offset: 0x00000500
	private void GGODFBDMIQF(byte[] DLJJQDQBOQD, char DPQFDCNLLPC)
	{
	}

	// Token: 0x060047CC RID: 18380 RVA: 0x0001E358 File Offset: 0x0001C558
	private void OnApplicationQuit()
	{
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
			this.CBMLQJPGPMO.Dispose();
		}
		this.CBMLQJPGPMO = null;
	}

	// Token: 0x060047CD RID: 18381 RVA: 0x00002300 File Offset: 0x00000500
	private void ONEEBKDEHJC(byte[] DLJJQDQBOQD, char DPQFDCNLLPC)
	{
	}

	// Token: 0x060047CE RID: 18382 RVA: 0x00237EE0 File Offset: 0x002360E0
	private void GHBFIQFIBKP()
	{
		if (this.HIPPQEBDHKO())
		{
			IProto[] responses = this.CBMLQJPGPMO.GetResponses();
			for (int i = 1; i < responses.Length; i++)
			{
				IProto proto = responses[i];
				if (!(proto is DebugMessage))
				{
					if (proto is MapServerMap)
					{
						MapServerMap mapServerMap = (MapServerMap)proto;
						if (mapServerMap.MapData == null)
						{
							MCNLIHMMLCF.HGLDHNMOLPD().PFGBGNDFBHK(mapServerMap.MapName, mapServerMap.Hash);
						}
						else if (((MapServerMap)proto).IsSession)
						{
							MCNLIHMMLCF.IECKOKEPENM().OHLGIOMHHGP(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
						else
						{
							MCNLIHMMLCF.KKICFMLLMHQ().HEEENMHQGIF(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
					}
					else if (proto is MAPAPI.Response.DeleteMap)
					{
						MCNLIHMMLCF.IECKOKEPENM().JONGMGMECHQ(((MAPAPI.Response.DeleteMap)proto).MapName);
					}
				}
			}
		}
	}

	// Token: 0x060047CF RID: 18383 RVA: 0x0001E3E2 File Offset: 0x0001C5E2
	public void LOOPKKKHCQK()
	{
		this.CBMLQJPGPMO.Disconnect();
		this.ODOGMJJQQKE = true;
	}

	// Token: 0x060047D0 RID: 18384 RVA: 0x00237FC0 File Offset: 0x002361C0
	private void DCJQFJOICGQ()
	{
		if (GameObject.Find("_1"))
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.gameObject.name = " and ";
		DOMONILEIKL.HBFFCJHOCPE = this;
		this.CBMLQJPGPMO = new Connection();
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	// Token: 0x060047D1 RID: 18385 RVA: 0x0023801C File Offset: 0x0023621C
	private void EHBDNIOCHNO()
	{
		if (this.FMKFIELEILJ())
		{
			IProto[] responses = this.CBMLQJPGPMO.GetResponses();
			for (int i = 1; i < responses.Length; i += 0)
			{
				IProto proto = responses[i];
				if (!(proto is DebugMessage))
				{
					if (proto is MapServerMap)
					{
						MapServerMap mapServerMap = (MapServerMap)proto;
						if (mapServerMap.MapData == null)
						{
							MCNLIHMMLCF.IECKOKEPENM().GGINJJCLQPK(mapServerMap.MapName, mapServerMap.Hash);
						}
						else if (((MapServerMap)proto).IsSession)
						{
							MCNLIHMMLCF.QOQONHOOLNE.HEEENMHQGIF(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
						else
						{
							MCNLIHMMLCF.QOQONHOOLNE.QMIDGOFDEGP(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
					}
					else if (proto is MAPAPI.Response.DeleteMap)
					{
						MCNLIHMMLCF.QOQONHOOLNE.JPMCOIOPLLP(((MAPAPI.Response.DeleteMap)proto).MapName);
					}
				}
			}
		}
	}

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x060047D2 RID: 18386 RVA: 0x0001E351 File Offset: 0x0001C551
	public static DOMONILEIKL QOQONHOOLNE
	{
		get
		{
			return DOMONILEIKL.HBFFCJHOCPE;
		}
	}

	// Token: 0x060047D3 RID: 18387 RVA: 0x0001E33A File Offset: 0x0001C53A
	public bool JGMMEQHEDOO()
	{
		return this.CBMLQJPGPMO == null || this.CBMLQJPGPMO.IsConnected;
	}

	// Token: 0x060047D4 RID: 18388 RVA: 0x0001E37F File Offset: 0x0001C57F
	public void HLIOFPONLLE(Proto DCGCLGQCGDQ)
	{
		if (this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected)
		{
			this.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
		}
	}

	// Token: 0x060047D5 RID: 18389 RVA: 0x0001E351 File Offset: 0x0001C551
	public static DOMONILEIKL PDPCLOECLOF()
	{
		return DOMONILEIKL.HBFFCJHOCPE;
	}

	// Token: 0x060047D6 RID: 18390 RVA: 0x0001E37F File Offset: 0x0001C57F
	public void OQBLDHILMGE(Proto DCGCLGQCGDQ)
	{
		if (this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected)
		{
			this.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
		}
	}

	// Token: 0x060047D7 RID: 18391 RVA: 0x002380FC File Offset: 0x002362FC
	public bool EIMQEOJDIJB()
	{
		if (!this.HIPPQEBDHKO() && !this.ODOGMJJQQKE)
		{
			try
			{
				this.ODOGMJJQQKE = true;
				this.CBMLQJPGPMO.Connect(this.MGKCHOQDBQD, this.BLJNJLGJHLD);
				while (this.CBMLQJPGPMO.Status == ConnectionStatus.Connecting)
				{
				}
				if (!this.PQKKDBPDHOO())
				{
					this.LOOPKKKHCQK();
				}
				else
				{
					this.KHOPKBQOLDJ(new Login
					{
						Username = "16.5 17\n15 17\n15 20\n22 20\n\n22 8\n19 8\n19 5\n16 5\n16 2\n27 2\n27 5\n22 5",
						Password = "[-]"
					});
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
			this.ODOGMJJQQKE = false;
			return this.FMKFIELEILJ();
		}
		return false;
	}

	// Token: 0x060047D8 RID: 18392 RVA: 0x0001E37F File Offset: 0x0001C57F
	public void CBMILEIBEJF(Proto DCGCLGQCGDQ)
	{
		if (this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected)
		{
			this.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
		}
	}

	// Token: 0x060047D9 RID: 18393 RVA: 0x00002300 File Offset: 0x00000500
	private void CDLFICFGHOE(byte[] DLJJQDQBOQD, char DPQFDCNLLPC)
	{
	}

	// Token: 0x060047DA RID: 18394 RVA: 0x002381AC File Offset: 0x002363AC
	private void JBJBPIBCBQO()
	{
		if (this.FIOFNJKPDQN())
		{
			IProto[] responses = this.CBMLQJPGPMO.GetResponses();
			for (int i = 1; i < responses.Length; i += 0)
			{
				IProto proto = responses[i];
				if (!(proto is DebugMessage))
				{
					if (proto is MapServerMap)
					{
						MapServerMap mapServerMap = (MapServerMap)proto;
						if (mapServerMap.MapData == null)
						{
							MCNLIHMMLCF.QOQONHOOLNE.HIQJCBDPQHF(mapServerMap.MapName, mapServerMap.Hash);
						}
						else if (((MapServerMap)proto).IsSession)
						{
							MCNLIHMMLCF.IECKOKEPENM().OHLGIOMHHGP(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
						else
						{
							MCNLIHMMLCF.OMPHLNDGKKM().QMIDGOFDEGP(mapServerMap.MapData, mapServerMap.MapName, false, mapServerMap.Hash);
						}
					}
					else if (proto is MAPAPI.Response.DeleteMap)
					{
						MCNLIHMMLCF.QOQONHOOLNE.JPMCOIOPLLP(((MAPAPI.Response.DeleteMap)proto).MapName);
					}
				}
			}
		}
	}

	// Token: 0x060047DB RID: 18395 RVA: 0x0023828C File Offset: 0x0023648C
	public bool EPNBECQFKEK()
	{
		if (!this.JOQBIMQCNDO && !this.ODOGMJJQQKE)
		{
			try
			{
				this.ODOGMJJQQKE = true;
				this.CBMLQJPGPMO.Connect(this.MGKCHOQDBQD, this.BLJNJLGJHLD);
				while (this.CBMLQJPGPMO.Status == ConnectionStatus.Connecting)
				{
				}
				if (!this.JOQBIMQCNDO)
				{
					this.NJNCGMFPHFI();
				}
				else
				{
					this.HLIOFPONLLE(new Login
					{
						Username = "Client",
						Password = "#PGSEONEp0k326783&^@#dgg4G@$W"
					});
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
			this.ODOGMJJQQKE = false;
			return this.JOQBIMQCNDO;
		}
		return false;
	}

	// Token: 0x060047DC RID: 18396 RVA: 0x00002300 File Offset: 0x00000500
	private void MBPBOPPMBKF(byte[] DLJJQDQBOQD, char DPQFDCNLLPC)
	{
	}

	// Token: 0x060047DD RID: 18397 RVA: 0x0001E351 File Offset: 0x0001C551
	public static DOMONILEIKL BJLGEDCPENQ()
	{
		return DOMONILEIKL.HBFFCJHOCPE;
	}

	// Token: 0x060047DE RID: 18398 RVA: 0x0001E3CB File Offset: 0x0001C5CB
	public bool MBBGPCOOQDP()
	{
		return this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected;
	}

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x060047DF RID: 18399 RVA: 0x0001E3CB File Offset: 0x0001C5CB
	public bool JOQBIMQCNDO
	{
		get
		{
			return this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected;
		}
	}

	// Token: 0x060047E0 RID: 18400 RVA: 0x0023833C File Offset: 0x0023653C
	private void JENKEGOEEHO()
	{
		if (GameObject.Find(" endured the hit!\r\n"))
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.gameObject.name = "par";
		DOMONILEIKL.HBFFCJHOCPE = this;
		this.CBMLQJPGPMO = new Connection();
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	// Token: 0x060047E1 RID: 18401 RVA: 0x00238398 File Offset: 0x00236598
	private void CLNOPBFEBID()
	{
		if (this.JOQBIMQCNDO)
		{
			foreach (IProto proto in this.CBMLQJPGPMO.GetResponses())
			{
				if (!(proto is DebugMessage))
				{
					if (proto is MapServerMap)
					{
						MapServerMap mapServerMap = (MapServerMap)proto;
						if (mapServerMap.MapData == null)
						{
							MCNLIHMMLCF.OMPHLNDGKKM().GGINJJCLQPK(mapServerMap.MapName, mapServerMap.Hash);
						}
						else if (((MapServerMap)proto).IsSession)
						{
							MCNLIHMMLCF.IECKOKEPENM().HEEENMHQGIF(mapServerMap.MapData, mapServerMap.MapName, true, mapServerMap.Hash);
						}
						else
						{
							MCNLIHMMLCF.QOQONHOOLNE.HEEENMHQGIF(mapServerMap.MapData, mapServerMap.MapName, true, mapServerMap.Hash);
						}
					}
					else if (proto is MAPAPI.Response.DeleteMap)
					{
						MCNLIHMMLCF.QOQONHOOLNE.JPMCOIOPLLP(((MAPAPI.Response.DeleteMap)proto).MapName);
					}
				}
			}
		}
	}

	// Token: 0x04000F39 RID: 3897
	private static DOMONILEIKL HBFFCJHOCPE;

	// Token: 0x04000F3A RID: 3898
	public Connection CBMLQJPGPMO;

	// Token: 0x04000F3B RID: 3899
	public int BLJNJLGJHLD = 2015;

	// Token: 0x04000F3C RID: 3900
	public string MGKCHOQDBQD = "127.0.0.1";

	// Token: 0x04000F3D RID: 3901
	public bool ODOGMJJQQKE;

	// Token: 0x04000F3E RID: 3902
	public string HEDDGCKJBDQ = ".psx";
}
