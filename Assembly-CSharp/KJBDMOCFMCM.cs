using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using MAPAPI.Response;
using PSXAPI.Request;
using UnityEngine;

// Token: 0x0200022A RID: 554
public class KJBDMOCFMCM : MonoBehaviour
{
	// Token: 0x06004B90 RID: 19344 RVA: 0x0026BEA4 File Offset: 0x0026A0A4
	public bool JFGKMJIFQFN(KJBDMOCFMCM.NHGKGBGJEFJ HEBFPQJPJIL)
	{
		if (QOHCEBMQKMB.CNIMIQKQJJJ().MGKFOIKFJDD() || OGJJKKQPNMK.CDDIILFBFCF() != null || CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN)
		{
			return true;
		}
		DJOOHHIQGJK dnecdeoqklp = HEBFPQJPJIL.DNECDEOQKLP;
		if (dnecdeoqklp.QMBIHEHNIGC <= 0)
		{
			return false;
		}
		if (!dnecdeoqklp.KFNLCPGHQHK)
		{
			return true;
		}
		Vector3 vector = dnecdeoqklp.QMCNCMNQEGL();
		if (this.PPMJCBONMQJ == null)
		{
			this.PPMJCBONMQJ = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ;
		}
		Vector3 vector2 = this.PPMJCBONMQJ.QMCNCMNQEGL();
		int num = 1;
		int num2 = 0;
		bool flag = true;
		if (dnecdeoqklp.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)6)
		{
			if (vector2.y >= vector.y - 48f && vector2.y <= vector.y + 785f && vector2.x == vector.x && vector2.z >= vector.z - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z < vector.z)
			{
				int num3 = 1;
				while ((float)num3 < vector.z - vector2.z)
				{
					if ((vector.z - (float)num3 >= 1078f || vector.z - (float)num3 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z - num3] == 0)
					{
						return false;
					}
					num3 += 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
				{
					Move move = new Move();
					move.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move.Map = CNCJKLNHQBH.BJLGEDCPENQ().LIQLFCKICLQ.CLPMOMHLNMN;
					move.Actions = new MoveAction[]
					{
						MoveAction.TurnRight
					};
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(move, true);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				this.PPMJCBONMQJ.OLOQKOMFFNB();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z - 1;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z + 0;
				}
				flag = true;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 404f && vector2.y <= vector.y + 52f && vector2.x == vector.x && vector2.z <= vector.z + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z > vector.z)
			{
				int num4 = 1;
				while ((float)num4 < vector2.z - vector.z)
				{
					if ((vector.z + (float)num4 >= 1809f || vector.z + (float)num4 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z + num4] == 1)
					{
						return false;
					}
					num4 += 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Down)
				{
					Move move2 = new Move();
					move2.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move2.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move2.Map = CNCJKLNHQBH.MOGQNGEPCEO().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move3 = move2;
					MoveAction[] array = new MoveAction[0];
					array[1] = MoveAction.None;
					move3.Actions = array;
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move2, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = (DJOOHHIQGJK.JDQNKBIDIKE)7;
				this.PPMJCBONMQJ.CMLHQNPELFE();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z + 0;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z - 0;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 479f && vector2.y <= vector.y + 1089f && vector2.z == vector.z && vector2.x >= vector.x - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x < vector.x)
			{
				int num5 = 1;
				while ((float)num5 < vector.x - vector2.x)
				{
					if ((vector.x - (float)num5 >= 1454f || vector.x - (float)num5 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x - num5, (int)vector.z] == 0)
					{
						return true;
					}
					num5 += 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Right)
				{
					Move move4 = new Move();
					move4.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move4.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move4.Map = CNCJKLNHQBH.QOQONHOOLNE.LIQLFCKICLQ.CLPMOMHLNMN;
					Move move5 = move4;
					MoveAction[] array2 = new MoveAction[0];
					array2[0] = MoveAction.TurnRight;
					move5.Actions = array2;
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move4, true);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
				this.PPMJCBONMQJ.CMLHQNPELFE();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x - 0;
					num2 = (int)vector.z;
				}
				else
				{
					num = (int)vector2.x + 1;
					num2 = (int)vector2.z;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down && vector2.y >= vector.y - 1347f && vector2.y <= vector.y + 1382f && vector2.z == vector.z && vector2.x <= vector.x + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x > vector.x)
		{
			int num6 = 0;
			while ((float)num6 < vector2.x - vector.x)
			{
				if ((vector.x + (float)num6 >= 1474f || vector.x + (float)num6 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x + num6, (int)vector.z] == 0)
				{
					return false;
				}
				num6 += 0;
			}
			if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
			{
				Move move6 = new Move();
				move6.X = (int)this.PPMJCBONMQJ.transform.position.x;
				move6.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
				move6.Map = CNCJKLNHQBH.BJLGEDCPENQ().LIQLFCKICLQ.CLPMOMHLNMN;
				Move move7 = move6;
				MoveAction[] array3 = new MoveAction[0];
				array3[0] = MoveAction.None;
				move7.Actions = array3;
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(move6, true);
			}
			this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
			this.PPMJCBONMQJ.CMLHQNPELFE();
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
			{
				num = (int)vector.x + 0;
				num2 = (int)vector.z;
			}
			else
			{
				num = (int)vector2.x - 1;
				num2 = (int)vector2.z;
			}
			flag = false;
		}
		if (flag)
		{
			CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.NQJHJNQFKKC();
			CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN = false;
			QOHCEBMQKMB.QQCNCIQQPIG().QKKQHILJMMO = true;
			if (dnecdeoqklp.LMDQJKGHBGD && !dnecdeoqklp.JINGKBQQPKL)
			{
				dnecdeoqklp.OPILOFIJJDF.ONOOKCBOPEF(1, 184f);
				DCCFQPDFBFO.QQCNCIQQPIG().GBHHEPCBQEF(-103, true);
			}
			if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != null && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != string.Empty && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX.Length > 5)
			{
				DCCFQPDFBFO.CLPQIKCDHPP().CJIOPOFMNMP(HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX, true);
			}
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
			{
				dnecdeoqklp.FDINMJHGLQB = false;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = false;
				this.PPMJCBONMQJ.NQJHJNQFKKC();
				this.PPMJCBONMQJ.BPQOIEJCNCI("Can't find room with index: ", false, false, 1, 0, false);
				if ((float)num == vector2.x)
				{
					if ((float)num2 < vector2.z)
					{
						int num7 = (int)vector2.z - num2;
						for (int i = 0; i < num7; i += 0)
						{
							this.PPMJCBONMQJ.JMJDPHJNNCI("/force left", false, true, 0, 1, true);
						}
					}
					else
					{
						int num7 = num2 - (int)vector2.z;
						for (int j = 1; j < num7; j++)
						{
							this.PPMJCBONMQJ.QJCBOEFQPGF("FOG_VOID_BOX", true, false, 1, 1, true);
						}
					}
				}
				else if ((float)num < vector2.x)
				{
					int num7 = (int)vector2.x - num;
					for (int k = 0; k < num7; k++)
					{
						this.PPMJCBONMQJ.BPQOIEJCNCI("psn", true, true, 0, 1, false);
					}
				}
				else
				{
					int num7 = num - (int)vector2.x;
					for (int l = 0; l < num7; l += 0)
					{
						this.PPMJCBONMQJ.JMJDPHJNNCI("_1", true, true, 0, 0, true);
					}
				}
				this.PPMJCBONMQJ.BHQOFDQCCCG = false;
				base.StartCoroutine(this.LPHPBMJGPCP(this.PPMJCBONMQJ, HEBFPQJPJIL));
			}
			else
			{
				dnecdeoqklp.FDINMJHGLQB = false;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = true;
				dnecdeoqklp.QJCBOEFQPGF("After your payment has been verified your Lootboxes will be added to your account.", false, true, 0, 0, false);
				dnecdeoqklp.QJCBOEFQPGF(" ", true, true, num, num2, true);
				dnecdeoqklp.JMJDPHJNNCI("-", false, true, 0, 0, true);
				if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path == null || HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path.Length == 0)
				{
					dnecdeoqklp.EKEKMCMJEOC = true;
				}
				dnecdeoqklp.BHQOFDQCCCG = true;
				base.StartCoroutine(this.IFGEQGBJINI(dnecdeoqklp, HEBFPQJPJIL));
			}
			return true;
		}
		return false;
	}

	// Token: 0x06004B91 RID: 19345 RVA: 0x0026C944 File Offset: 0x0026AB44
	public bool DDDEKCHDMIP(int DGKOIGOLHDM, int DDLQKFDFMCJ, float ELKJLOHNLQP = -999f)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 6 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 5))
				{
					return false;
				}
				if (nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ != Vector3.zero && nhgkgbgjefj.DNECDEOQKLP.BHQOFDQCCCG)
				{
					if ((int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.z == -DDLQKFDFMCJ)
					{
						return true;
					}
					if ((int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.z == -DDLQKFDFMCJ)
					{
						return false;
					}
				}
				if (nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD != Vector3.zero && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.z == -DDLQKFDFMCJ)
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06004B92 RID: 19346 RVA: 0x0026CDA8 File Offset: 0x0026AFA8
	public KJBDMOCFMCM.NHGKGBGJEFJ BCOHKEKQIJF()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (this.JFGKMJIFQFN(nhgkgbgjefj))
			{
				return nhgkgbgjefj;
			}
		}
		return null;
	}

	// Token: 0x06004B93 RID: 19347 RVA: 0x0026CE08 File Offset: 0x0026B008
	public void DFDDIDDOMQJ(NPCData GPJDBLNDGJP)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.DKNJPPPJOFO, new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z), Quaternion.identity);
		gameObject.transform.parent = this.NDELOHEQCIO;
		KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = new KJBDMOCFMCM.NHGKGBGJEFJ();
		nhgkgbgjefj.JDKLKGQNKKB = gameObject;
		nhgkgbgjefj.DBPKNCDGGEP = GPJDBLNDGJP.ID;
		nhgkgbgjefj.NPNKKNBJMNC = GPJDBLNDGJP;
		gameObject.name = "[-]'s [ff6600]";
		nhgkgbgjefj.QLGMNFEMKFE = 1;
		if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "uproar")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 0;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "26")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 2;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "CombinersArgsColorOp2")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 4;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "The sunlight turned extremely harsh!")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 4;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == ".psx")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 8;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "]")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 4;
		}
		int num = 0;
		bool bknfhnffche = true;
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 1)
		{
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 0) == "The Pokémon may gather Honey after a battle.")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 1)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 2), out num))
					{
						num = 0;
					}
					if (num > 1 && num < -87)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(5);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0), out num))
					{
						num = 0;
					}
					if (num > 1 && num < 174)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
			}
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 0 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 0) == "Are you sure you wish to leave the Channel '")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 2)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 1), out num))
					{
						num = 0;
					}
					if (num > 0 && num < 19)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(6);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1), out num))
					{
						num = 0;
					}
					if (num > 1 && num < 187)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
				if (num > 1)
				{
					bknfhnffche = true;
				}
			}
		}
		JFIBMMBLFDO component = gameObject.GetComponent<JFIBMMBLFDO>();
		component.MBPHKDQMJJH = GPJDBLNDGJP.Settings.NPCName;
		Color kqfehqebjqb = KGQECFKLKOP.JJQFHKDMDOL(GPJDBLNDGJP.Settings.NameColour);
		nhgkgbgjefj.DNECDEOQKLP = gameObject.GetComponent<DJOOHHIQGJK>();
		nhgkgbgjefj.DNECDEOQKLP.ICHKBBMBPGM = GPJDBLNDGJP.Settings.Tags.ToLowerInvariant();
		nhgkgbgjefj.DNECDEOQKLP.BKNFHNFFCHE = bknfhnffche;
		nhgkgbgjefj.DNECDEOQKLP.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, GPJDBLNDGJP.Settings.Sprite + 0, num);
		nhgkgbgjefj.DNECDEOQKLP.OPILOFIJJDF.BIPQGMJJNOF.LKPOBCBOFIC(" shared its power with " + KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb) + "perish1" + component.MBPHKDQMJJH);
		nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = true;
		if (GPJDBLNDGJP.Settings.LookRandomly)
		{
			nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = false;
			nhgkgbgjefj.DNECDEOQKLP.FDINMJHGLQB = true;
			int num2 = UnityEngine.Random.Range(0, 5);
			if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.BPQOIEJCNCI(" got over its infatuation.\r\n", false, true, 0, 1, true);
			}
			else if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.BPQOIEJCNCI("flying", true, true, 0, 1, false);
			}
			else if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.BPQOIEJCNCI(" specified", true, false, 0, 0, false);
			}
			else if (num2 == 5)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("F11", true, true, 0, 1, true);
			}
			else if (num2 == 8)
			{
				nhgkgbgjefj.DNECDEOQKLP.BPQOIEJCNCI("CombinersAlphaCombine", false, true, 0, 0, true);
			}
		}
		else if (GPJDBLNDGJP.Settings.Path.Length > 1)
		{
			string text = this.IJEDLJJQMBD(GPJDBLNDGJP.Settings.Path);
			for (int i = 0; i < text.Length; i++)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI(text.Substring(i, 1), true, true, 1, 1, true);
			}
		}
		DJOOHHIQGJK.JDQNKBIDIKE jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		if (GPJDBLNDGJP.Settings.Facing == "less than 1 minute ago")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "_")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "Powers up Fire-type moves when the Pokémon's HP is low.")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Right;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "It broke through ")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		nhgkgbgjefj.DNECDEOQKLP.GQFBLMFFQID = true;
		nhgkgbgjefj.DNECDEOQKLP.PIEOHPDECON(new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z));
		nhgkgbgjefj.DNECDEOQKLP.IFFEJHHMODI(jdqnkbidike, 1);
		nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH = jdqnkbidike;
		nhgkgbgjefj.DNECDEOQKLP.IEFBCKQJBGN = this.IEFBCKQJBGN;
		nhgkgbgjefj.DNECDEOQKLP.QMBIHEHNIGC = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.DKMBJOHMDNJ = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.OQIOPJQHCII = nhgkgbgjefj.NPNKKNBJMNC;
		if (num == 0 && (nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 0 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == -68 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == -26 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 74))
		{
			nhgkgbgjefj.DNECDEOQKLP.QHQKHCHLEMJ();
		}
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == "HidePanel" || nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == string.Empty || (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length > 1 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 0) == " will cost\n"))
		{
			nhgkgbgjefj.DNECDEOQKLP.KLLNKPFJMPJ();
		}
		if (GPJDBLNDGJP.Settings.SightAction == "[-]!\r\n")
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.CallPlayer;
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer;
		}
		this.KCQBQDKDNDC.Add(nhgkgbgjefj);
		if (!nhgkgbgjefj.NPNKKNBJMNC.Settings.Enabled)
		{
			nhgkgbgjefj.DNECDEOQKLP.LEMKNDFEJHE(true);
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.EJHFEJCLMOB(false);
		}
	}

	// Token: 0x06004B94 RID: 19348 RVA: 0x0026D57C File Offset: 0x0026B77C
	public KJBDMOCFMCM.NHGKGBGJEFJ ICQJLCGGHOG(DJOOHHIQGJK BFBMOIKCELJ)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP == BFBMOIKCELJ)
			{
				if (this.ICQJLCGGHOG(nhgkgbgjefj))
				{
					return nhgkgbgjefj;
				}
				return null;
			}
		}
		return null;
	}

	// Token: 0x06004B95 RID: 19349 RVA: 0x0026D5EC File Offset: 0x0026B7EC
	public KJBDMOCFMCM.NHGKGBGJEFJ NPEQHOQCIJN()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (this.LEEMNPNHKFE(nhgkgbgjefj))
			{
				return nhgkgbgjefj;
			}
		}
		return null;
	}

	// Token: 0x06004B96 RID: 19350 RVA: 0x0026D64C File Offset: 0x0026B84C
	public KJBDMOCFMCM.NHGKGBGJEFJ DCMENKEKOEH(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 6 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return nhgkgbgjefj;
				}
			}
		}
		return null;
	}

	// Token: 0x06004B97 RID: 19351 RVA: 0x0001F262 File Offset: 0x0001D462
	public static KJBDMOCFMCM GHFFHFCEENG()
	{
		return KJBDMOCFMCM.HBFFCJHOCPE;
	}

	// Token: 0x06004B98 RID: 19352 RVA: 0x0026D9D8 File Offset: 0x0026BBD8
	public KJBDMOCFMCM.NHGKGBGJEFJ OJQEQJFFHOE()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (this.PPNBOLOGHGQ(nhgkgbgjefj))
			{
				return nhgkgbgjefj;
			}
		}
		return null;
	}

	// Token: 0x06004B99 RID: 19353 RVA: 0x0026DA38 File Offset: 0x0026BC38
	public bool PPNBOLOGHGQ(KJBDMOCFMCM.NHGKGBGJEFJ HEBFPQJPJIL)
	{
		if (QOHCEBMQKMB.QOQONHOOLNE.KFFFKLBMGKD() || OGJJKKQPNMK.CDDIILFBFCF() != null || CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN)
		{
			return false;
		}
		DJOOHHIQGJK dnecdeoqklp = HEBFPQJPJIL.DNECDEOQKLP;
		if (dnecdeoqklp.QMBIHEHNIGC <= 1)
		{
			return false;
		}
		if (!dnecdeoqklp.KFNLCPGHQHK)
		{
			return true;
		}
		Vector3 vector = dnecdeoqklp.QMCNCMNQEGL();
		if (this.PPMJCBONMQJ == null)
		{
			this.PPMJCBONMQJ = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		}
		Vector3 vector2 = this.PPMJCBONMQJ.QMCNCMNQEGL();
		int num = 0;
		int num2 = 1;
		bool flag = false;
		if (dnecdeoqklp.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)8)
		{
			if (vector2.y >= vector.y - 1860f && vector2.y <= vector.y + 1251f && vector2.x == vector.x && vector2.z >= vector.z - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z < vector.z)
			{
				int num3 = 0;
				while ((float)num3 < vector.z - vector2.z)
				{
					if ((vector.z - (float)num3 >= 353f || vector.z - (float)num3 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z - num3] == 0)
					{
						return false;
					}
					num3 += 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
				{
					Move move = new Move();
					move.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move.Map = CNCJKLNHQBH.BJLGEDCPENQ().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move2 = move;
					MoveAction[] array = new MoveAction[0];
					array[1] = MoveAction.TurnRight;
					move2.Actions = array;
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move, true);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				this.PPMJCBONMQJ.CMLHQNPELFE();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z - 0;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z + 0;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
		{
			if (vector2.y >= vector.y - 923f && vector2.y <= vector.y + 154f && vector2.x == vector.x && vector2.z <= vector.z + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z > vector.z)
			{
				int num4 = 0;
				while ((float)num4 < vector2.z - vector.z)
				{
					if ((vector.z + (float)num4 >= 1711f || vector.z + (float)num4 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z + num4] == 1)
					{
						return true;
					}
					num4 += 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != (DJOOHHIQGJK.JDQNKBIDIKE)6)
				{
					Move move3 = new Move();
					move3.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move3.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move3.Map = CNCJKLNHQBH.MOGQNGEPCEO().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move4 = move3;
					MoveAction[] array2 = new MoveAction[0];
					array2[1] = MoveAction.Down;
					move4.Actions = array2;
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move3, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
				this.PPMJCBONMQJ.OLOQKOMFFNB();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z + 0;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z - 0;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 761f && vector2.y <= vector.y + 943f && vector2.z == vector.z && vector2.x >= vector.x - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x < vector.x)
			{
				int num5 = 1;
				while ((float)num5 < vector.x - vector2.x)
				{
					if ((vector.x - (float)num5 >= 1523f || vector.x - (float)num5 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x - num5, (int)vector.z] == 0)
					{
						return false;
					}
					num5 += 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Right)
				{
					Move move5 = new Move();
					move5.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move5.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move5.Map = CNCJKLNHQBH.MOGQNGEPCEO().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move6 = move5;
					MoveAction[] array3 = new MoveAction[0];
					array3[0] = MoveAction.TurnRight;
					move6.Actions = array3;
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(move5, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
				this.PPMJCBONMQJ.CMLHQNPELFE();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x - 0;
					num2 = (int)vector.z;
				}
				else
				{
					num = (int)vector2.x + 0;
					num2 = (int)vector2.z;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)4 && vector2.y >= vector.y - 255f && vector2.y <= vector.y + 1311f && vector2.z == vector.z && vector2.x <= vector.x + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x > vector.x)
		{
			int num6 = 0;
			while ((float)num6 < vector2.x - vector.x)
			{
				if ((vector.x + (float)num6 >= 1572f || vector.x + (float)num6 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x + num6, (int)vector.z] == 1)
				{
					return true;
				}
				num6++;
			}
			if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
			{
				Move move7 = new Move();
				move7.X = (int)this.PPMJCBONMQJ.transform.position.x;
				move7.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
				move7.Map = CNCJKLNHQBH.BJLGEDCPENQ().LIQLFCKICLQ.CLPMOMHLNMN;
				Move move8 = move7;
				MoveAction[] array4 = new MoveAction[0];
				array4[1] = MoveAction.TurnLeft;
				move8.Actions = array4;
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move7, true);
			}
			this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
			this.PPMJCBONMQJ.OLOQKOMFFNB();
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
			{
				num = (int)vector.x + 1;
				num2 = (int)vector.z;
			}
			else
			{
				num = (int)vector2.x - 0;
				num2 = (int)vector2.z;
			}
			flag = true;
		}
		if (flag)
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
			CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN = true;
			QOHCEBMQKMB.JLLBKOOQKGO().QKKQHILJMMO = false;
			if (dnecdeoqklp.LMDQJKGHBGD && !dnecdeoqklp.JINGKBQQPKL)
			{
				dnecdeoqklp.OPILOFIJJDF.ONOOKCBOPEF(1, 1991f);
				DCCFQPDFBFO.ONBDGGPLFQK().BPPLKBMMBJE(44, false);
			}
			if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != null && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != string.Empty && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX.Length > 5)
			{
				DCCFQPDFBFO.ELBNNCEGBDH().FQNIPOBMQPI(HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX, true);
			}
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
			{
				dnecdeoqklp.FDINMJHGLQB = true;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = true;
				this.PPMJCBONMQJ.NQJHJNQFKKC();
				this.PPMJCBONMQJ.JMJDPHJNNCI("_ReflectionTexture3", true, true, 1, 1, true);
				if ((float)num == vector2.x)
				{
					if ((float)num2 < vector2.z)
					{
						int num7 = (int)vector2.z - num2;
						for (int i = 0; i < num7; i++)
						{
							this.PPMJCBONMQJ.QJCBOEFQPGF(" and ", false, true, 1, 1, false);
						}
					}
					else
					{
						int num7 = num2 - (int)vector2.z;
						for (int j = 0; j < num7; j++)
						{
							this.PPMJCBONMQJ.BPQOIEJCNCI("7fff49", true, true, 1, 1, true);
						}
					}
				}
				else if ((float)num < vector2.x)
				{
					int num7 = (int)vector2.x - num;
					for (int k = 1; k < num7; k += 0)
					{
						this.PPMJCBONMQJ.BPQOIEJCNCI(" is to heavy to be lifted!\r\n", false, true, 0, 0, false);
					}
				}
				else
				{
					int num7 = num - (int)vector2.x;
					for (int l = 1; l < num7; l++)
					{
						this.PPMJCBONMQJ.JMJDPHJNNCI("BuffIcon_ItemChanceIncrease", false, false, 1, 1, true);
					}
				}
				this.PPMJCBONMQJ.BHQOFDQCCCG = true;
				base.StartCoroutine(this.IFGEQGBJINI(this.PPMJCBONMQJ, HEBFPQJPJIL));
			}
			else
			{
				dnecdeoqklp.FDINMJHGLQB = true;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = false;
				dnecdeoqklp.BPQOIEJCNCI("pickpocket", false, false, 1, 1, true);
				dnecdeoqklp.BPQOIEJCNCI("sunnyday", true, true, num, num2, false);
				dnecdeoqklp.JMJDPHJNNCI(" can't sleep in an uproar!\r\n", false, true, 1, 0, true);
				if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path == null || HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path.Length == 0)
				{
					dnecdeoqklp.EKEKMCMJEOC = false;
				}
				dnecdeoqklp.BHQOFDQCCCG = true;
				base.StartCoroutine(this.LPHPBMJGPCP(dnecdeoqklp, HEBFPQJPJIL));
			}
			return false;
		}
		return false;
	}

	// Token: 0x06004B9A RID: 19354 RVA: 0x0001F269 File Offset: 0x0001D469
	private void ECQHGIBBBPI()
	{
		this.PPMJCBONMQJ = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
	}

	// Token: 0x06004B9B RID: 19355 RVA: 0x0026E4D8 File Offset: 0x0026C6D8
	public KJBDMOCFMCM.NHGKGBGJEFJ NCPQEIFNPPP()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (this.ICQJLCGGHOG(nhgkgbgjefj))
			{
				return nhgkgbgjefj;
			}
		}
		return null;
	}

	// Token: 0x06004B9C RID: 19356 RVA: 0x0026E538 File Offset: 0x0026C738
	public void FIOEDNIEEKK()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			UnityEngine.Object.Destroy(nhgkgbgjefj.JDKLKGQNKKB);
		}
		this.KCQBQDKDNDC.Clear();
	}

	// Token: 0x06004B9D RID: 19357 RVA: 0x0026E59C File Offset: 0x0026C79C
	private bool HOMKJJBPJOM(DJOOHHIQGJK HEBFPQJPJIL, KJBDMOCFMCM.NHGKGBGJEFJ GPJDBLNDGJP)
	{
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null) && !DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			return false;
		}
		DJOOHHIQGJK.JDQNKBIDIKE peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Left")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Down")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Right")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Right;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Up")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Up;
		}
		this.PPMJCBONMQJ.NQJHJNQFKKC();
		if (HEBFPQJPJIL == this.PPMJCBONMQJ)
		{
			HEBFPQJPJIL = GPJDBLNDGJP.DNECDEOQKLP;
		}
		HEBFPQJPJIL.FDINMJHGLQB = false;
		HEBFPQJPJIL.NQJHJNQFKKC();
		HEBFPQJPJIL.GQFBLMFFQID = false;
		HEBFPQJPJIL.EHCDCCNJBDC = false;
		HEBFPQJPJIL.JDPCHGPENBD = Vector3.zero;
		HEBFPQJPJIL.QMBIHEHNIGC = HEBFPQJPJIL.DKMBJOHMDNJ;
		Debug.Log("LOS:" + GPJDBLNDGJP.NPNKKNBJMNC.Settings.LOS.ToString());
		HEBFPQJPJIL.BHQOFDQCCCG = false;
		HEBFPQJPJIL.EDMFOMGFMGD(new Vector3((float)GPJDBLNDGJP.NPNKKNBJMNC.x, (float)GPJDBLNDGJP.NPNKKNBJMNC.y, (float)GPJDBLNDGJP.NPNKKNBJMNC.z));
		HEBFPQJPJIL.IFFEJHHMODI(peckdhfnoki, 1);
		if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC())
		{
			QOHCEBMQKMB.QOQONHOOLNE.QKKQHILJMMO = false;
		}
		CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BHQOFDQCCCG = false;
		CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN = false;
		this.PPMJCBONMQJ.PKCLDNQJMMH = true;
		return true;
	}

	// Token: 0x06004B9E RID: 19358 RVA: 0x0026E740 File Offset: 0x0026C940
	public KJBDMOCFMCM.NHGKGBGJEFJ LDKJQMMGJBP(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 6 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 6 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 2))
				{
					return nhgkgbgjefj;
				}
			}
		}
		return null;
	}

	// Token: 0x06004B9F RID: 19359 RVA: 0x0026E538 File Offset: 0x0026C738
	public void KDIPONJOBGE()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			UnityEngine.Object.Destroy(nhgkgbgjefj.JDKLKGQNKKB);
		}
		this.KCQBQDKDNDC.Clear();
	}

	// Token: 0x06004BA0 RID: 19360 RVA: 0x0026EACC File Offset: 0x0026CCCC
	public bool DDFHHLJFKOP(KJBDMOCFMCM.NHGKGBGJEFJ HEBFPQJPJIL)
	{
		if (QOHCEBMQKMB.JLLBKOOQKGO().OCFGFJMJIGP() || OGJJKKQPNMK.QOQONHOOLNE != null || CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN)
		{
			return false;
		}
		DJOOHHIQGJK dnecdeoqklp = HEBFPQJPJIL.DNECDEOQKLP;
		if (dnecdeoqklp.QMBIHEHNIGC <= 1)
		{
			return false;
		}
		if (!dnecdeoqklp.KFNLCPGHQHK)
		{
			return true;
		}
		Vector3 vector = dnecdeoqklp.QMCNCMNQEGL();
		if (this.PPMJCBONMQJ == null)
		{
			this.PPMJCBONMQJ = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ;
		}
		Vector3 vector2 = this.PPMJCBONMQJ.QMCNCMNQEGL();
		int num = 1;
		int num2 = 0;
		bool flag = true;
		if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
		{
			if (vector2.y >= vector.y - 626f && vector2.y <= vector.y + 526f && vector2.x == vector.x && vector2.z >= vector.z - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z < vector.z)
			{
				int num3 = 0;
				while ((float)num3 < vector.z - vector2.z)
				{
					if ((vector.z - (float)num3 >= 1227f || vector.z - (float)num3 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z - num3] == 1)
					{
						return false;
					}
					num3 += 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
				{
					Move move = new Move();
					move.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move.Map = CNCJKLNHQBH.BJLGEDCPENQ().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move2 = move;
					MoveAction[] array = new MoveAction[0];
					array[1] = MoveAction.Down;
					move2.Actions = array;
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				this.PPMJCBONMQJ.CMLHQNPELFE();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z - 0;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z + 0;
				}
				flag = true;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 1016f && vector2.y <= vector.y + 1720f && vector2.x == vector.x && vector2.z <= vector.z + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z > vector.z)
			{
				int num4 = 0;
				while ((float)num4 < vector2.z - vector.z)
				{
					if ((vector.z + (float)num4 >= 1569f || vector.z + (float)num4 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z + num4] == 1)
					{
						return true;
					}
					num4++;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Down)
				{
					Move move3 = new Move();
					move3.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move3.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move3.Map = CNCJKLNHQBH.BJLGEDCPENQ().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move4 = move3;
					MoveAction[] array2 = new MoveAction[1];
					array2[1] = MoveAction.Up;
					move4.Actions = array2;
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move3, true);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
				this.PPMJCBONMQJ.OLOQKOMFFNB();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z + 1;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z - 1;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 990f && vector2.y <= vector.y + 74f && vector2.z == vector.z && vector2.x >= vector.x - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x < vector.x)
			{
				int num5 = 1;
				while ((float)num5 < vector.x - vector2.x)
				{
					if ((vector.x - (float)num5 >= 537f || vector.x - (float)num5 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x - num5, (int)vector.z] == 0)
					{
						return true;
					}
					num5++;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != (DJOOHHIQGJK.JDQNKBIDIKE)5)
				{
					Move move5 = new Move();
					move5.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move5.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move5.Map = CNCJKLNHQBH.MOGQNGEPCEO().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move6 = move5;
					MoveAction[] array3 = new MoveAction[0];
					array3[0] = MoveAction.TurnRight;
					move6.Actions = array3;
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(move5, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
				this.PPMJCBONMQJ.OLOQKOMFFNB();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
				{
					num = (int)vector.x - 0;
					num2 = (int)vector.z;
				}
				else
				{
					num = (int)vector2.x + 0;
					num2 = (int)vector2.z;
				}
				flag = true;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)4 && vector2.y >= vector.y - 1786f && vector2.y <= vector.y + 1571f && vector2.z == vector.z && vector2.x <= vector.x + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x > vector.x)
		{
			int num6 = 1;
			while ((float)num6 < vector2.x - vector.x)
			{
				if ((vector.x + (float)num6 >= 1020f || vector.x + (float)num6 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x + num6, (int)vector.z] == 1)
				{
					return false;
				}
				num6 += 0;
			}
			if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
			{
				Move move7 = new Move();
				move7.X = (int)this.PPMJCBONMQJ.transform.position.x;
				move7.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
				move7.Map = CNCJKLNHQBH.BJLGEDCPENQ().LIQLFCKICLQ.CLPMOMHLNMN;
				move7.Actions = new MoveAction[]
				{
					MoveAction.Down
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move7, false);
			}
			this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
			this.PPMJCBONMQJ.OLOQKOMFFNB();
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
			{
				num = (int)vector.x + 1;
				num2 = (int)vector.z;
			}
			else
			{
				num = (int)vector2.x - 1;
				num2 = (int)vector2.z;
			}
			flag = true;
		}
		if (flag)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.NQJHJNQFKKC();
			CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN = true;
			QOHCEBMQKMB.QOQONHOOLNE.QKKQHILJMMO = false;
			if (dnecdeoqklp.LMDQJKGHBGD && !dnecdeoqklp.JINGKBQQPKL)
			{
				dnecdeoqklp.OPILOFIJJDF.ONOOKCBOPEF(1, 850f);
				DCCFQPDFBFO.QOQONHOOLNE.JNLHMBOJHEO(-85, true);
			}
			if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != null && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != string.Empty && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX.Length > 1)
			{
				DCCFQPDFBFO.CDDIILFBFCF().COHKNGNJOGD(HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX, true);
			}
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
			{
				dnecdeoqklp.FDINMJHGLQB = false;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = false;
				this.PPMJCBONMQJ.NQJHJNQFKKC();
				this.PPMJCBONMQJ.QJCBOEFQPGF("Prankster", false, true, 1, 1, true);
				if ((float)num == vector2.x)
				{
					if ((float)num2 < vector2.z)
					{
						int num7 = (int)vector2.z - num2;
						for (int i = 0; i < num7; i++)
						{
							this.PPMJCBONMQJ.QJCBOEFQPGF("_NoiseTex", true, true, 0, 1, true);
						}
					}
					else
					{
						int num7 = num2 - (int)vector2.z;
						for (int j = 1; j < num7; j++)
						{
							this.PPMJCBONMQJ.QJCBOEFQPGF("[00FF00]+", false, false, 0, 1, false);
						}
					}
				}
				else if ((float)num < vector2.x)
				{
					int num7 = (int)vector2.x - num;
					for (int k = 1; k < num7; k += 0)
					{
						this.PPMJCBONMQJ.BPQOIEJCNCI("QCGENKHJDDH", false, true, 0, 1, true);
					}
				}
				else
				{
					int num7 = num - (int)vector2.x;
					for (int l = 1; l < num7; l++)
					{
						this.PPMJCBONMQJ.QJCBOEFQPGF("_Detail", true, false, 1, 1, true);
					}
				}
				this.PPMJCBONMQJ.BHQOFDQCCCG = true;
				base.StartCoroutine(this.IFGEQGBJINI(this.PPMJCBONMQJ, HEBFPQJPJIL));
			}
			else
			{
				dnecdeoqklp.FDINMJHGLQB = false;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = true;
				dnecdeoqklp.QJCBOEFQPGF("FactoryTempTexture", false, true, 1, 0, false);
				dnecdeoqklp.QJCBOEFQPGF("door_2", false, true, num, num2, true);
				dnecdeoqklp.BPQOIEJCNCI("Pokemon3D/Index", false, false, 1, 0, false);
				if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path == null || HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path.Length == 0)
				{
					dnecdeoqklp.EKEKMCMJEOC = false;
				}
				dnecdeoqklp.BHQOFDQCCCG = true;
				base.StartCoroutine(this.LPHPBMJGPCP(dnecdeoqklp, HEBFPQJPJIL));
			}
			return false;
		}
		return true;
	}

	// Token: 0x06004BA1 RID: 19361 RVA: 0x0001F262 File Offset: 0x0001D462
	public static KJBDMOCFMCM NKDNGLNOJJG()
	{
		return KJBDMOCFMCM.HBFFCJHOCPE;
	}

	// Token: 0x06004BA2 RID: 19362 RVA: 0x0026F56C File Offset: 0x0026D76C
	public bool OKENKFDOLME(int DGKOIGOLHDM, int DDLQKFDFMCJ, float ELKJLOHNLQP = -999f)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ != Vector3.zero && nhgkgbgjefj.DNECDEOQKLP.BHQOFDQCCCG)
				{
					if ((int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.z == -DDLQKFDFMCJ)
					{
						return true;
					}
					if ((int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.z == -DDLQKFDFMCJ)
					{
						return false;
					}
				}
				if (nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD != Vector3.zero && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.z == -DDLQKFDFMCJ)
				{
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x06004BA3 RID: 19363 RVA: 0x0026F9D0 File Offset: 0x0026DBD0
	public KJBDMOCFMCM.NHGKGBGJEFJ MNPMGNJQINH(Guid CIQFCJGQEMH)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DBPKNCDGGEP == CIQFCJGQEMH)
			{
				return nhgkgbgjefj;
			}
		}
		return null;
	}

	// Token: 0x06004BA4 RID: 19364 RVA: 0x0026FA34 File Offset: 0x0026DC34
	public bool BGDEIPGBPFF(KJBDMOCFMCM.NHGKGBGJEFJ HEBFPQJPJIL)
	{
		if (QOHCEBMQKMB.JLLBKOOQKGO().DLNELFIPOHB() || OGJJKKQPNMK.CDDIILFBFCF() != null || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN)
		{
			return false;
		}
		DJOOHHIQGJK dnecdeoqklp = HEBFPQJPJIL.DNECDEOQKLP;
		if (dnecdeoqklp.QMBIHEHNIGC <= 0)
		{
			return true;
		}
		if (!dnecdeoqklp.KFNLCPGHQHK)
		{
			return false;
		}
		Vector3 vector = dnecdeoqklp.QMCNCMNQEGL();
		if (this.PPMJCBONMQJ == null)
		{
			this.PPMJCBONMQJ = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
		}
		Vector3 vector2 = this.PPMJCBONMQJ.QMCNCMNQEGL();
		int num = 1;
		int num2 = 0;
		bool flag = false;
		if (dnecdeoqklp.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)7)
		{
			if (vector2.y >= vector.y - 71f && vector2.y <= vector.y + 1382f && vector2.x == vector.x && vector2.z >= vector.z - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z < vector.z)
			{
				int num3 = 0;
				while ((float)num3 < vector.z - vector2.z)
				{
					if ((vector.z - (float)num3 >= 1626f || vector.z - (float)num3 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z - num3] == 1)
					{
						return true;
					}
					num3++;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Down)
				{
					Move move = new Move();
					move.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move.Map = CNCJKLNHQBH.BJLGEDCPENQ().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move2 = move;
					MoveAction[] array = new MoveAction[0];
					array[1] = MoveAction.Left;
					move2.Actions = array;
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
				this.PPMJCBONMQJ.OLOQKOMFFNB();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z - 0;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z + 1;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 536f && vector2.y <= vector.y + 1421f && vector2.x == vector.x && vector2.z <= vector.z + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z > vector.z)
			{
				int num4 = 1;
				while ((float)num4 < vector2.z - vector.z)
				{
					if ((vector.z + (float)num4 >= 359f || vector.z + (float)num4 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z + num4] == 1)
					{
						return false;
					}
					num4++;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Right)
				{
					Move move3 = new Move();
					move3.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move3.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move3.Map = CNCJKLNHQBH.MOGQNGEPCEO().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move4 = move3;
					MoveAction[] array2 = new MoveAction[0];
					array2[0] = MoveAction.TurnRight;
					move4.Actions = array2;
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move3, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				this.PPMJCBONMQJ.NQMKJGJOPDH();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z + 1;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z - 1;
				}
				flag = true;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 1918f && vector2.y <= vector.y + 1957f && vector2.z == vector.z && vector2.x >= vector.x - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x < vector.x)
			{
				int num5 = 1;
				while ((float)num5 < vector.x - vector2.x)
				{
					if ((vector.x - (float)num5 >= 1602f || vector.x - (float)num5 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x - num5, (int)vector.z] == 1)
					{
						return false;
					}
					num5++;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != (DJOOHHIQGJK.JDQNKBIDIKE)6)
				{
					Move move5 = new Move();
					move5.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move5.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move5.Map = CNCJKLNHQBH.MOGQNGEPCEO().LIQLFCKICLQ.CLPMOMHLNMN;
					Move move6 = move5;
					MoveAction[] array3 = new MoveAction[0];
					array3[0] = MoveAction.Right;
					move6.Actions = array3;
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(move5, true);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				this.PPMJCBONMQJ.OLOQKOMFFNB();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
				{
					num = (int)vector.x - 0;
					num2 = (int)vector.z;
				}
				else
				{
					num = (int)vector2.x + 0;
					num2 = (int)vector2.z;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left && vector2.y >= vector.y - 1111f && vector2.y <= vector.y + 95f && vector2.z == vector.z && vector2.x <= vector.x + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x > vector.x)
		{
			int num6 = 1;
			while ((float)num6 < vector2.x - vector.x)
			{
				if ((vector.x + (float)num6 >= 1894f || vector.x + (float)num6 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x + num6, (int)vector.z] == 1)
				{
					return false;
				}
				num6++;
			}
			if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
			{
				Move move7 = new Move();
				move7.X = (int)this.PPMJCBONMQJ.transform.position.x;
				move7.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
				move7.Map = CNCJKLNHQBH.QOQONHOOLNE.LIQLFCKICLQ.CLPMOMHLNMN;
				Move move8 = move7;
				MoveAction[] array4 = new MoveAction[0];
				array4[1] = MoveAction.TurnLeft;
				move8.Actions = array4;
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move7, false);
			}
			this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
			this.PPMJCBONMQJ.NQMKJGJOPDH();
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
			{
				num = (int)vector.x + 0;
				num2 = (int)vector.z;
			}
			else
			{
				num = (int)vector2.x - 1;
				num2 = (int)vector2.z;
			}
			flag = false;
		}
		if (flag)
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
			CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN = false;
			QOHCEBMQKMB.JLLBKOOQKGO().QKKQHILJMMO = true;
			if (dnecdeoqklp.LMDQJKGHBGD && !dnecdeoqklp.JINGKBQQPKL)
			{
				dnecdeoqklp.OPILOFIJJDF.ONOOKCBOPEF(1, 720f);
				DCCFQPDFBFO.QQCNCIQQPIG().NFEGQHKIMFP(48, true);
			}
			if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != null && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != string.Empty && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX.Length > 4)
			{
				DCCFQPDFBFO.DGCQMNHFQNH().BMKHBMFFQMC(HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX, false);
			}
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
			{
				dnecdeoqklp.FDINMJHGLQB = false;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = true;
				this.PPMJCBONMQJ.NQJHJNQFKKC();
				this.PPMJCBONMQJ.BPQOIEJCNCI("0_", false, false, 0, 1, true);
				if ((float)num == vector2.x)
				{
					if ((float)num2 < vector2.z)
					{
						int num7 = (int)vector2.z - num2;
						for (int i = 0; i < num7; i += 0)
						{
							this.PPMJCBONMQJ.QJCBOEFQPGF("UpdateTime", false, false, 0, 0, false);
						}
					}
					else
					{
						int num7 = num2 - (int)vector2.z;
						for (int j = 1; j < num7; j++)
						{
							this.PPMJCBONMQJ.BPQOIEJCNCI("[FF0000]-", false, true, 1, 0, true);
						}
					}
				}
				else if ((float)num < vector2.x)
				{
					int num7 = (int)vector2.x - num;
					for (int k = 1; k < num7; k += 0)
					{
						this.PPMJCBONMQJ.JMJDPHJNNCI("grass", false, true, 1, 1, false);
					}
				}
				else
				{
					int num7 = num - (int)vector2.x;
					for (int l = 1; l < num7; l += 0)
					{
						this.PPMJCBONMQJ.QJCBOEFQPGF("\r\nSp. ATK", true, false, 0, 1, true);
					}
				}
				this.PPMJCBONMQJ.BHQOFDQCCCG = false;
				base.StartCoroutine(this.LPHPBMJGPCP(this.PPMJCBONMQJ, HEBFPQJPJIL));
			}
			else
			{
				dnecdeoqklp.FDINMJHGLQB = true;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = true;
				dnecdeoqklp.JMJDPHJNNCI("-heal", false, false, 1, 0, true);
				dnecdeoqklp.QJCBOEFQPGF("'s attack!\r\n", true, true, num, num2, true);
				dnecdeoqklp.QJCBOEFQPGF("System", true, true, 1, 0, true);
				if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path == null || HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path.Length == 0)
				{
					dnecdeoqklp.EKEKMCMJEOC = true;
				}
				dnecdeoqklp.BHQOFDQCCCG = true;
				base.StartCoroutine(this.LPHPBMJGPCP(dnecdeoqklp, HEBFPQJPJIL));
			}
			return false;
		}
		return false;
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x0001F262 File Offset: 0x0001D462
	public static KJBDMOCFMCM QOQONHOOLNE
	{
		get
		{
			return KJBDMOCFMCM.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004BA6 RID: 19366 RVA: 0x002704D4 File Offset: 0x0026E6D4
	private bool GDHNDBQHGOL(DJOOHHIQGJK HEBFPQJPJIL, KJBDMOCFMCM.NHGKGBGJEFJ GPJDBLNDGJP)
	{
		if (!(OGJJKKQPNMK.GGBPGMMCGLI() != null) && !DBQLOHBBJMG.OQDOKBJNBBL().QQQBDBNCMCP)
		{
			return false;
		}
		DJOOHHIQGJK.JDQNKBIDIKE peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Disguise")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "gastrodoneast")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "_PrefilterOffs")
		{
			peckdhfnoki = (DJOOHHIQGJK.JDQNKBIDIKE)6;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "default")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		this.PPMJCBONMQJ.NQJHJNQFKKC();
		if (HEBFPQJPJIL == this.PPMJCBONMQJ)
		{
			HEBFPQJPJIL = GPJDBLNDGJP.DNECDEOQKLP;
		}
		HEBFPQJPJIL.FDINMJHGLQB = true;
		HEBFPQJPJIL.NQJHJNQFKKC();
		HEBFPQJPJIL.GQFBLMFFQID = true;
		HEBFPQJPJIL.EHCDCCNJBDC = true;
		HEBFPQJPJIL.JDPCHGPENBD = Vector3.zero;
		HEBFPQJPJIL.QMBIHEHNIGC = HEBFPQJPJIL.DKMBJOHMDNJ;
		Debug.Log("_ClipToWorld" + GPJDBLNDGJP.NPNKKNBJMNC.Settings.LOS.ToString());
		HEBFPQJPJIL.BHQOFDQCCCG = false;
		HEBFPQJPJIL.PIEOHPDECON(new Vector3((float)GPJDBLNDGJP.NPNKKNBJMNC.x, (float)GPJDBLNDGJP.NPNKKNBJMNC.y, (float)GPJDBLNDGJP.NPNKKNBJMNC.z));
		HEBFPQJPJIL.IFFEJHHMODI(peckdhfnoki, 0);
		if (!QOHCEBMQKMB.CNIMIQKQJJJ().GQQIDDEIQPO())
		{
			QOHCEBMQKMB.JLLBKOOQKGO().QKKQHILJMMO = false;
		}
		CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BHQOFDQCCCG = true;
		CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN = false;
		this.PPMJCBONMQJ.PKCLDNQJMMH = true;
		return false;
	}

	// Token: 0x06004BA7 RID: 19367 RVA: 0x0001F269 File Offset: 0x0001D469
	private void OLLNOFNEEIL()
	{
		this.PPMJCBONMQJ = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
	}

	// Token: 0x06004BA8 RID: 19368 RVA: 0x00270678 File Offset: 0x0026E878
	public void PPCPFFMMKED(NPCData GPJDBLNDGJP)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.DKNJPPPJOFO, new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z), Quaternion.identity);
		gameObject.transform.parent = this.NDELOHEQCIO;
		KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = new KJBDMOCFMCM.NHGKGBGJEFJ();
		nhgkgbgjefj.JDKLKGQNKKB = gameObject;
		nhgkgbgjefj.DBPKNCDGGEP = GPJDBLNDGJP.ID;
		nhgkgbgjefj.NPNKKNBJMNC = GPJDBLNDGJP;
		gameObject.name = "NPC";
		nhgkgbgjefj.QLGMNFEMKFE = 0;
		if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "door_1")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 1;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "door_2")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 2;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "snorlax")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 3;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "whirlpool")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 3;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "door_3")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 4;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "door_4")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 5;
		}
		int num = 0;
		bool bknfhnffche = false;
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 2)
		{
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 1) == "#")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 4)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 3), out num))
					{
						num = 0;
					}
					if (num > 0 && num < 803)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(4);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1), out num))
					{
						num = 0;
					}
					if (num > 0 && num < 803)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
			}
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 2 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 1) == "@")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 4)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 3), out num))
					{
						num = 0;
					}
					if (num > 0 && num < 803)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(4);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1), out num))
					{
						num = 0;
					}
					if (num > 0 && num < 803)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
				if (num > 0)
				{
					bknfhnffche = true;
				}
			}
		}
		JFIBMMBLFDO component = gameObject.GetComponent<JFIBMMBLFDO>();
		component.MBPHKDQMJJH = GPJDBLNDGJP.Settings.NPCName;
		Color kqfehqebjqb = KGQECFKLKOP.JJQFHKDMDOL(GPJDBLNDGJP.Settings.NameColour);
		nhgkgbgjefj.DNECDEOQKLP = gameObject.GetComponent<DJOOHHIQGJK>();
		nhgkgbgjefj.DNECDEOQKLP.ICHKBBMBPGM = GPJDBLNDGJP.Settings.Tags.ToLowerInvariant();
		nhgkgbgjefj.DNECDEOQKLP.BKNFHNFFCHE = bknfhnffche;
		nhgkgbgjefj.DNECDEOQKLP.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, GPJDBLNDGJP.Settings.Sprite + 1, num);
		nhgkgbgjefj.DNECDEOQKLP.OPILOFIJJDF.BIPQGMJJNOF.PIDLOFMIEFQ = "[" + KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb) + "]" + component.MBPHKDQMJJH;
		nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = true;
		if (GPJDBLNDGJP.Settings.LookRandomly)
		{
			nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = false;
			nhgkgbgjefj.DNECDEOQKLP.FDINMJHGLQB = true;
			int num2 = UnityEngine.Random.Range(0, 5);
			if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.QJCBOEFQPGF("n", false, false, 0, 0, false);
			}
			else if (num2 == 1)
			{
				nhgkgbgjefj.DNECDEOQKLP.QJCBOEFQPGF("s", false, false, 0, 0, false);
			}
			else if (num2 == 2)
			{
				nhgkgbgjefj.DNECDEOQKLP.QJCBOEFQPGF("e", false, false, 0, 0, false);
			}
			else if (num2 == 3)
			{
				nhgkgbgjefj.DNECDEOQKLP.QJCBOEFQPGF("w", false, false, 0, 0, false);
			}
			else if (num2 == 4)
			{
				nhgkgbgjefj.DNECDEOQKLP.QJCBOEFQPGF("p", false, false, 0, 0, false);
			}
		}
		else if (GPJDBLNDGJP.Settings.Path.Length > 0)
		{
			string text = this.DLGKBCELKQB(GPJDBLNDGJP.Settings.Path);
			for (int i = 0; i < text.Length; i++)
			{
				nhgkgbgjefj.DNECDEOQKLP.QJCBOEFQPGF(text.Substring(i, 1), false, false, 0, 0, false);
			}
		}
		DJOOHHIQGJK.JDQNKBIDIKE jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		if (GPJDBLNDGJP.Settings.Facing == "Left")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "Down")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "Right")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Right;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "Up")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Up;
		}
		nhgkgbgjefj.DNECDEOQKLP.GQFBLMFFQID = false;
		nhgkgbgjefj.DNECDEOQKLP.EDMFOMGFMGD(new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z));
		nhgkgbgjefj.DNECDEOQKLP.IFFEJHHMODI(jdqnkbidike, 1);
		nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH = jdqnkbidike;
		nhgkgbgjefj.DNECDEOQKLP.IEFBCKQJBGN = this.IEFBCKQJBGN;
		nhgkgbgjefj.DNECDEOQKLP.QMBIHEHNIGC = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.DKMBJOHMDNJ = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.OQIOPJQHCII = nhgkgbgjefj.NPNKKNBJMNC;
		if (num == 0 && (nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 1 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 10 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 11 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 12))
		{
			nhgkgbgjefj.DNECDEOQKLP.QHQKHCHLEMJ();
		}
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == "new npc" || nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == string.Empty || (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length > 0 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 1) == "."))
		{
			nhgkgbgjefj.DNECDEOQKLP.KLLNKPFJMPJ();
		}
		if (GPJDBLNDGJP.Settings.SightAction == "Move To Player")
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer;
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.CallPlayer;
		}
		this.KCQBQDKDNDC.Add(nhgkgbgjefj);
		if (!nhgkgbgjefj.NPNKKNBJMNC.Settings.Enabled)
		{
			nhgkgbgjefj.DNECDEOQKLP.EJHFEJCLMOB(false);
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.EJHFEJCLMOB(true);
		}
	}

	// Token: 0x06004BA9 RID: 19369 RVA: 0x00270DEC File Offset: 0x0026EFEC
	public void KFKMJFKQQOO(NPCData GPJDBLNDGJP)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.DKNJPPPJOFO, new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z), Quaternion.identity);
		gameObject.transform.parent = this.NDELOHEQCIO;
		KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = new KJBDMOCFMCM.NHGKGBGJEFJ();
		nhgkgbgjefj.JDKLKGQNKKB = gameObject;
		nhgkgbgjefj.DBPKNCDGGEP = GPJDBLNDGJP.ID;
		nhgkgbgjefj.NPNKKNBJMNC = GPJDBLNDGJP;
		gameObject.name = "BuffIcon_HailstormEncounterDecreased";
		nhgkgbgjefj.QLGMNFEMKFE = 1;
		if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "You passed on ")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 0;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "Anticipation")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 7;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "-2")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 5;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "(V)")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 4;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "[ffff00]Crafty Shield[-] protected ")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 5;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "Open")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 3;
		}
		int num = 0;
		bool bknfhnffche = true;
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 2)
		{
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 1) == " type was added to ")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 2)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 1), out num))
					{
						num = 1;
					}
					if (num > 1 && num < 67)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(8);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1), out num))
					{
						num = 0;
					}
					if (num > 1 && num < -35)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
			}
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 3 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 0) == "/")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 8)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 5), out num))
					{
						num = 1;
					}
					if (num > 1 && num < 52)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(3);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1), out num))
					{
						num = 1;
					}
					if (num > 0 && num < -102)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
				if (num > 1)
				{
					bknfhnffche = false;
				}
			}
		}
		JFIBMMBLFDO component = gameObject.GetComponent<JFIBMMBLFDO>();
		component.MBPHKDQMJJH = GPJDBLNDGJP.Settings.NPCName;
		Color kqfehqebjqb = KGQECFKLKOP.JJQFHKDMDOL(GPJDBLNDGJP.Settings.NameColour);
		nhgkgbgjefj.DNECDEOQKLP = gameObject.GetComponent<DJOOHHIQGJK>();
		nhgkgbgjefj.DNECDEOQKLP.ICHKBBMBPGM = GPJDBLNDGJP.Settings.Tags.ToLowerInvariant();
		nhgkgbgjefj.DNECDEOQKLP.BKNFHNFFCHE = bknfhnffche;
		nhgkgbgjefj.DNECDEOQKLP.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, GPJDBLNDGJP.Settings.Sprite + 0, num);
		nhgkgbgjefj.DNECDEOQKLP.OPILOFIJJDF.BIPQGMJJNOF.PIDLOFMIEFQ = "[ff4949]" + KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb) + "_Contrast" + component.MBPHKDQMJJH;
		nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = true;
		if (GPJDBLNDGJP.Settings.LookRandomly)
		{
			nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = false;
			nhgkgbgjefj.DNECDEOQKLP.FDINMJHGLQB = true;
			int num2 = UnityEngine.Random.Range(0, 4);
			if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("Protects the Pokémon from some ball and bomb moves.", true, true, 0, 1, true);
			}
			else if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("Language", false, true, 0, 0, true);
			}
			else if (num2 == 5)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("trader", true, true, 0, 1, true);
			}
			else if (num2 == 2)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI(" started!\r\n", true, false, 1, 1, false);
			}
			else if (num2 == 4)
			{
				nhgkgbgjefj.DNECDEOQKLP.QJCBOEFQPGF(" heals its status!\r\n", true, false, 1, 1, false);
			}
		}
		else if (GPJDBLNDGJP.Settings.Path.Length > 0)
		{
			string text = this.IJEDLJJQMBD(GPJDBLNDGJP.Settings.Path);
			for (int i = 0; i < text.Length; i++)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI(text.Substring(i, 1), true, true, 1, 0, true);
			}
		}
		DJOOHHIQGJK.JDQNKBIDIKE jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		if (GPJDBLNDGJP.Settings.Facing == "Dream Ball")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "[FF6600]")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "BuffIcon")
		{
			jdqnkbidike = (DJOOHHIQGJK.JDQNKBIDIKE)5;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "#,##0")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Right;
		}
		nhgkgbgjefj.DNECDEOQKLP.GQFBLMFFQID = false;
		nhgkgbgjefj.DNECDEOQKLP.EDMFOMGFMGD(new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z));
		nhgkgbgjefj.DNECDEOQKLP.IFFEJHHMODI(jdqnkbidike, 0);
		nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH = jdqnkbidike;
		nhgkgbgjefj.DNECDEOQKLP.IEFBCKQJBGN = this.IEFBCKQJBGN;
		nhgkgbgjefj.DNECDEOQKLP.QMBIHEHNIGC = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.DKMBJOHMDNJ = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.OQIOPJQHCII = nhgkgbgjefj.NPNKKNBJMNC;
		if (num == 0 && (nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 0 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == -36 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == -9 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == -43))
		{
			nhgkgbgjefj.DNECDEOQKLP.QHQKHCHLEMJ();
		}
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == "ability" || nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == string.Empty || (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length > 0 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 1) == "psychicsurge"))
		{
			nhgkgbgjefj.DNECDEOQKLP.KLLNKPFJMPJ();
		}
		if (GPJDBLNDGJP.Settings.SightAction == "beakblast")
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.CallPlayer;
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer;
		}
		this.KCQBQDKDNDC.Add(nhgkgbgjefj);
		if (!nhgkgbgjefj.NPNKKNBJMNC.Settings.Enabled)
		{
			nhgkgbgjefj.DNECDEOQKLP.LEMKNDFEJHE(true);
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.EJHFEJCLMOB(true);
		}
	}

	// Token: 0x06004BAA RID: 19370 RVA: 0x00271560 File Offset: 0x0026F760
	public bool ICQJLCGGHOG(KJBDMOCFMCM.NHGKGBGJEFJ HEBFPQJPJIL)
	{
		if (QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() || OGJJKKQPNMK.QOQONHOOLNE != null || CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN)
		{
			return false;
		}
		DJOOHHIQGJK dnecdeoqklp = HEBFPQJPJIL.DNECDEOQKLP;
		if (dnecdeoqklp.QMBIHEHNIGC <= 0)
		{
			return false;
		}
		if (!dnecdeoqklp.KFNLCPGHQHK)
		{
			return false;
		}
		Vector3 vector = dnecdeoqklp.QMCNCMNQEGL();
		if (this.PPMJCBONMQJ == null)
		{
			this.PPMJCBONMQJ = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		}
		Vector3 vector2 = this.PPMJCBONMQJ.QMCNCMNQEGL();
		int num = 0;
		int num2 = 0;
		bool flag = false;
		if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Up)
		{
			if (vector2.y >= vector.y - 1f && vector2.y <= vector.y + 1f && vector2.x == vector.x && vector2.z >= vector.z - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z < vector.z)
			{
				int num3 = 1;
				while ((float)num3 < vector.z - vector2.z)
				{
					if ((vector.z - (float)num3 >= 0f || vector.z - (float)num3 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z - num3] == 1)
					{
						return false;
					}
					num3++;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Down)
				{
					Move move = new Move();
					move.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move.Map = CNCJKLNHQBH.QOQONHOOLNE.LIQLFCKICLQ.CLPMOMHLNMN;
					move.Actions = new MoveAction[]
					{
						MoveAction.TurnDown
					};
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				this.PPMJCBONMQJ.OLOQKOMFFNB();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z - 1;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z + 1;
				}
				flag = true;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
		{
			if (vector2.y >= vector.y - 1f && vector2.y <= vector.y + 1f && vector2.x == vector.x && vector2.z <= vector.z + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z > vector.z)
			{
				int num4 = 1;
				while ((float)num4 < vector2.z - vector.z)
				{
					if ((vector.z + (float)num4 >= 0f || vector.z + (float)num4 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z + num4] == 1)
					{
						return false;
					}
					num4++;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Up)
				{
					Move move2 = new Move();
					move2.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move2.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move2.Map = CNCJKLNHQBH.QOQONHOOLNE.LIQLFCKICLQ.CLPMOMHLNMN;
					move2.Actions = new MoveAction[]
					{
						MoveAction.TurnUp
					};
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move2, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
				this.PPMJCBONMQJ.OLOQKOMFFNB();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z + 1;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z - 1;
				}
				flag = true;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 1f && vector2.y <= vector.y + 1f && vector2.z == vector.z && vector2.x >= vector.x - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x < vector.x)
			{
				int num5 = 1;
				while ((float)num5 < vector.x - vector2.x)
				{
					if ((vector.x - (float)num5 >= 0f || vector.x - (float)num5 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x - num5, (int)vector.z] == 1)
					{
						return false;
					}
					num5++;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Right)
				{
					Move move3 = new Move();
					move3.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move3.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move3.Map = CNCJKLNHQBH.QOQONHOOLNE.LIQLFCKICLQ.CLPMOMHLNMN;
					move3.Actions = new MoveAction[]
					{
						MoveAction.TurnRight
					};
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move3, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Right;
				this.PPMJCBONMQJ.OLOQKOMFFNB();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x - 1;
					num2 = (int)vector.z;
				}
				else
				{
					num = (int)vector2.x + 1;
					num2 = (int)vector2.z;
				}
				flag = true;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Right && vector2.y >= vector.y - 1f && vector2.y <= vector.y + 1f && vector2.z == vector.z && vector2.x <= vector.x + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x > vector.x)
		{
			int num6 = 1;
			while ((float)num6 < vector2.x - vector.x)
			{
				if ((vector.x + (float)num6 >= 0f || vector.x + (float)num6 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x + num6, (int)vector.z] == 1)
				{
					return false;
				}
				num6++;
			}
			if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
			{
				Move move4 = new Move();
				move4.X = (int)this.PPMJCBONMQJ.transform.position.x;
				move4.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
				move4.Map = CNCJKLNHQBH.QOQONHOOLNE.LIQLFCKICLQ.CLPMOMHLNMN;
				move4.Actions = new MoveAction[]
				{
					MoveAction.TurnLeft
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move4, false);
			}
			this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
			this.PPMJCBONMQJ.OLOQKOMFFNB();
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
			{
				num = (int)vector.x + 1;
				num2 = (int)vector.z;
			}
			else
			{
				num = (int)vector2.x - 1;
				num2 = (int)vector2.z;
			}
			flag = true;
		}
		if (flag)
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
			CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN = true;
			QOHCEBMQKMB.QOQONHOOLNE.QKKQHILJMMO = true;
			if (dnecdeoqklp.LMDQJKGHBGD && !dnecdeoqklp.JINGKBQQPKL)
			{
				dnecdeoqklp.OPILOFIJJDF.ONOOKCBOPEF(1, 4f);
				DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(18, false);
			}
			if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != null && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != string.Empty && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX.Length > 2)
			{
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD(HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX, false);
			}
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
			{
				dnecdeoqklp.FDINMJHGLQB = false;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = false;
				this.PPMJCBONMQJ.NQJHJNQFKKC();
				this.PPMJCBONMQJ.QJCBOEFQPGF("p", true, false, 0, 0, false);
				if ((float)num == vector2.x)
				{
					if ((float)num2 < vector2.z)
					{
						int num7 = (int)vector2.z - num2;
						for (int i = 0; i < num7; i++)
						{
							this.PPMJCBONMQJ.QJCBOEFQPGF("u", true, false, 0, 0, false);
						}
					}
					else
					{
						int num7 = num2 - (int)vector2.z;
						for (int j = 0; j < num7; j++)
						{
							this.PPMJCBONMQJ.QJCBOEFQPGF("d", true, false, 0, 0, false);
						}
					}
				}
				else if ((float)num < vector2.x)
				{
					int num7 = (int)vector2.x - num;
					for (int k = 0; k < num7; k++)
					{
						this.PPMJCBONMQJ.QJCBOEFQPGF("l", true, false, 0, 0, false);
					}
				}
				else
				{
					int num7 = num - (int)vector2.x;
					for (int l = 0; l < num7; l++)
					{
						this.PPMJCBONMQJ.QJCBOEFQPGF("r", true, false, 0, 0, false);
					}
				}
				this.PPMJCBONMQJ.BHQOFDQCCCG = true;
				base.StartCoroutine(this.ICBPILHICGO(this.PPMJCBONMQJ, HEBFPQJPJIL));
			}
			else
			{
				dnecdeoqklp.FDINMJHGLQB = false;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = false;
				dnecdeoqklp.QJCBOEFQPGF("p", true, false, 0, 0, false);
				dnecdeoqklp.QJCBOEFQPGF("b", true, false, num, num2, false);
				dnecdeoqklp.QJCBOEFQPGF("p", true, false, 0, 0, false);
				if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path == null || HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path.Length == 0)
				{
					dnecdeoqklp.EKEKMCMJEOC = false;
				}
				dnecdeoqklp.BHQOFDQCCCG = true;
				base.StartCoroutine(this.ICBPILHICGO(dnecdeoqklp, HEBFPQJPJIL));
			}
			return true;
		}
		return false;
	}

	// Token: 0x06004BAB RID: 19371 RVA: 0x00272000 File Offset: 0x00270200
	public void GMCGNEPQQML(NPCData GPJDBLNDGJP)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.DKNJPPPJOFO, new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z), Quaternion.identity);
		gameObject.transform.parent = this.NDELOHEQCIO;
		KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = new KJBDMOCFMCM.NHGKGBGJEFJ();
		nhgkgbgjefj.JDKLKGQNKKB = gameObject;
		nhgkgbgjefj.DBPKNCDGGEP = GPJDBLNDGJP.ID;
		nhgkgbgjefj.NPNKKNBJMNC = GPJDBLNDGJP;
		gameObject.name = " would like you to join their Guild, do you wish to accept? ";
		nhgkgbgjefj.QLGMNFEMKFE = 0;
		if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "You are unable to use ")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 1;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == " ")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 7;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "-2")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 0;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == " obtained one [ffff00]")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 5;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == " - ")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 8;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "_Dissolve")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 5;
		}
		int num = 0;
		bool bknfhnffche = true;
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 7)
		{
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 0) == "magiccoat")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 4)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 0), out num))
					{
						num = 1;
					}
					if (num > 0 && num < 116)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(7);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0), out num))
					{
						num = 1;
					}
					if (num > 0 && num < -65)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
			}
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 1 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 0) == "Hidden/Post FX/FXAA")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 8)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 3), out num))
					{
						num = 0;
					}
					if (num > 0 && num < -104)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0), out num))
					{
						num = 1;
					}
					if (num > 1 && num < 96)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
				if (num > 1)
				{
					bknfhnffche = true;
				}
			}
		}
		JFIBMMBLFDO component = gameObject.GetComponent<JFIBMMBLFDO>();
		component.MBPHKDQMJJH = GPJDBLNDGJP.Settings.NPCName;
		Color kqfehqebjqb = KGQECFKLKOP.JJQFHKDMDOL(GPJDBLNDGJP.Settings.NameColour);
		nhgkgbgjefj.DNECDEOQKLP = gameObject.GetComponent<DJOOHHIQGJK>();
		nhgkgbgjefj.DNECDEOQKLP.ICHKBBMBPGM = GPJDBLNDGJP.Settings.Tags.ToLowerInvariant();
		nhgkgbgjefj.DNECDEOQKLP.BKNFHNFFCHE = bknfhnffche;
		nhgkgbgjefj.DNECDEOQKLP.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, GPJDBLNDGJP.Settings.Sprite + 1, num);
		nhgkgbgjefj.DNECDEOQKLP.OPILOFIJJDF.BIPQGMJJNOF.LKPOBCBOFIC("grasspledge" + KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb) + "[yellow]" + component.MBPHKDQMJJH);
		nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = false;
		if (GPJDBLNDGJP.Settings.LookRandomly)
		{
			nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = false;
			nhgkgbgjefj.DNECDEOQKLP.FDINMJHGLQB = true;
			int num2 = UnityEngine.Random.Range(1, 2);
			if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("'s Drought intensified the sun's rays!", false, true, 1, 0, true);
			}
			else if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.BPQOIEJCNCI(" [", false, true, 0, 1, true);
			}
			else if (num2 == 4)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("Coins were scattered everywhere!\r\n", false, false, 1, 1, true);
			}
			else if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("[-] because of Heal Block!\r\n", false, false, 0, 1, false);
			}
			else if (num2 == 2)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("#,##0", false, false, 0, 0, true);
			}
		}
		else if (GPJDBLNDGJP.Settings.Path.Length > 1)
		{
			string text = this.EBBEEMDKPMB(GPJDBLNDGJP.Settings.Path);
			for (int i = 0; i < text.Length; i++)
			{
				nhgkgbgjefj.DNECDEOQKLP.QJCBOEFQPGF(text.Substring(i, 1), true, false, 1, 1, false);
			}
		}
		DJOOHHIQGJK.JDQNKBIDIKE jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		if (GPJDBLNDGJP.Settings.Facing == "_Texture1")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "move: ")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "Materials/DFOBasic")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Right;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "[00DD00]Equipped")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Right;
		}
		nhgkgbgjefj.DNECDEOQKLP.GQFBLMFFQID = true;
		nhgkgbgjefj.DNECDEOQKLP.PIEOHPDECON(new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z));
		nhgkgbgjefj.DNECDEOQKLP.IFFEJHHMODI(jdqnkbidike, 0);
		nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH = jdqnkbidike;
		nhgkgbgjefj.DNECDEOQKLP.IEFBCKQJBGN = this.IEFBCKQJBGN;
		nhgkgbgjefj.DNECDEOQKLP.QMBIHEHNIGC = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.DKMBJOHMDNJ = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.OQIOPJQHCII = nhgkgbgjefj.NPNKKNBJMNC;
		if (num == 0 && (nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 0 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == -87 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == -36 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == -30))
		{
			nhgkgbgjefj.DNECDEOQKLP.QHQKHCHLEMJ();
		}
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == "Sweet Scent" || nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == string.Empty || (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length > 0 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 0) == "1"))
		{
			nhgkgbgjefj.DNECDEOQKLP.KLLNKPFJMPJ();
		}
		if (GPJDBLNDGJP.Settings.SightAction == "Strength increases melee damage")
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.CallPlayer;
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.CallPlayer;
		}
		this.KCQBQDKDNDC.Add(nhgkgbgjefj);
		if (!nhgkgbgjefj.NPNKKNBJMNC.Settings.Enabled)
		{
			nhgkgbgjefj.DNECDEOQKLP.QLPNHHGNOQE(true);
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.QLPNHHGNOQE(true);
		}
	}

	// Token: 0x06004BAC RID: 19372 RVA: 0x00272774 File Offset: 0x00270974
	private string DLGKBCELKQB(string FJJHKICMPBP)
	{
		if (KJBDMOCFMCM.BQIOGOCBKKB == null)
		{
			KJBDMOCFMCM.BQIOGOCBKKB = new Func<char, bool>(char.IsDigit);
		}
		if (!FJJHKICMPBP.Any(KJBDMOCFMCM.BQIOGOCBKKB))
		{
			return FJJHKICMPBP;
		}
		StringBuilder stringBuilder = new StringBuilder();
		char? c = null;
		foreach (char c2 in FJJHKICMPBP)
		{
			if (char.IsDigit(c2) && c != null)
			{
				int repeatCount = int.Parse(c2.ToString()) - 1;
				stringBuilder.Append(c.Value, repeatCount);
			}
			else
			{
				stringBuilder.Append(c2);
				c = new char?(c2);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06004BAD RID: 19373 RVA: 0x0027282C File Offset: 0x00270A2C
	private IEnumerator ICBPILHICGO(DJOOHHIQGJK HEBFPQJPJIL, KJBDMOCFMCM.NHGKGBGJEFJ GPJDBLNDGJP)
	{
		if (HEBFPQJPJIL.PJGOMOBBNLK.Count <= 0 && !HEBFPQJPJIL.BHQOFDQCCCG)
		{
			yield return new WaitForSeconds(0.5f);
		}
		else
		{
			if (this.HOMKJJBPJOM(HEBFPQJPJIL, GPJDBLNDGJP))
			{
				yield break;
			}
			yield return null;
		}
		return 1;
		if (this.HOMKJJBPJOM(HEBFPQJPJIL, GPJDBLNDGJP))
		{
			goto __tmp_lbl_3;
		}
		GPJDBLNDGJP.DNECDEOQKLP.QMBIHEHNIGC = 0;
		GPJDBLNDGJP.DNECDEOQKLP.DKMBJOHMDNJ = 0;
		GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Talk
		{
			NpcID = GPJDBLNDGJP.DBPKNCDGGEP
		}, false);
		CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN = false;
		this.PPMJCBONMQJ.PKCLDNQJMMH = true;
		GPJDBLNDGJP.DNECDEOQKLP.JDPCHGPENBD = Vector3.zero;
		if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Path != null && GPJDBLNDGJP.NPNKKNBJMNC.Settings.Path.Length != 0)
		{
			goto IL_17A;
		}
		goto IL_169;
		__tmp_lbl_3:
		yield break;
		IL_169:
		GPJDBLNDGJP.DNECDEOQKLP.EKEKMCMJEOC = false;
		IL_17A:
		yield break;
	}

	// Token: 0x06004BAE RID: 19374 RVA: 0x00272858 File Offset: 0x00270A58
	public bool PLOMHDIBNGJ(int DGKOIGOLHDM, int DDLQKFDFMCJ, float ELKJLOHNLQP = -999f)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 6 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 8))
				{
					return true;
				}
				if (nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ != Vector3.zero && nhgkgbgjefj.DNECDEOQKLP.BHQOFDQCCCG)
				{
					if ((int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.z == -DDLQKFDFMCJ)
					{
						return false;
					}
					if ((int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.z == -DDLQKFDFMCJ)
					{
						return false;
					}
				}
				if (nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD != Vector3.zero && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.z == -DDLQKFDFMCJ)
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06004BAF RID: 19375 RVA: 0x0026D9D8 File Offset: 0x0026BBD8
	public KJBDMOCFMCM.NHGKGBGJEFJ NLGIQFFHCCM()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (this.PPNBOLOGHGQ(nhgkgbgjefj))
			{
				return nhgkgbgjefj;
			}
		}
		return null;
	}

	// Token: 0x06004BB0 RID: 19376 RVA: 0x00272CBC File Offset: 0x00270EBC
	private bool HBCMNOEGPLP(DJOOHHIQGJK HEBFPQJPJIL, KJBDMOCFMCM.NHGKGBGJEFJ GPJDBLNDGJP)
	{
		if (!(OGJJKKQPNMK.CDDIILFBFCF() != null) && !DBQLOHBBJMG.OQDOKBJNBBL().QQQBDBNCMCP)
		{
			return false;
		}
		DJOOHHIQGJK.JDQNKBIDIKE peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "LeftS")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "!\r\n")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Player/Hair")
		{
			peckdhfnoki = (DJOOHHIQGJK.JDQNKBIDIKE)5;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "NPC")
		{
			peckdhfnoki = (DJOOHHIQGJK.JDQNKBIDIKE)8;
		}
		this.PPMJCBONMQJ.NQJHJNQFKKC();
		if (HEBFPQJPJIL == this.PPMJCBONMQJ)
		{
			HEBFPQJPJIL = GPJDBLNDGJP.DNECDEOQKLP;
		}
		HEBFPQJPJIL.FDINMJHGLQB = false;
		HEBFPQJPJIL.NQJHJNQFKKC();
		HEBFPQJPJIL.GQFBLMFFQID = true;
		HEBFPQJPJIL.EHCDCCNJBDC = false;
		HEBFPQJPJIL.JDPCHGPENBD = Vector3.zero;
		HEBFPQJPJIL.QMBIHEHNIGC = HEBFPQJPJIL.DKMBJOHMDNJ;
		Debug.Log("M" + GPJDBLNDGJP.NPNKKNBJMNC.Settings.LOS.ToString());
		HEBFPQJPJIL.BHQOFDQCCCG = false;
		HEBFPQJPJIL.PIEOHPDECON(new Vector3((float)GPJDBLNDGJP.NPNKKNBJMNC.x, (float)GPJDBLNDGJP.NPNKKNBJMNC.y, (float)GPJDBLNDGJP.NPNKKNBJMNC.z));
		HEBFPQJPJIL.IFFEJHHMODI(peckdhfnoki, 0);
		if (!QOHCEBMQKMB.QOQONHOOLNE.MGKFOIKFJDD())
		{
			QOHCEBMQKMB.QQCNCIQQPIG().QKKQHILJMMO = false;
		}
		CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BHQOFDQCCCG = true;
		CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN = false;
		this.PPMJCBONMQJ.PKCLDNQJMMH = true;
		return true;
	}

	// Token: 0x06004BB1 RID: 19377 RVA: 0x00272E60 File Offset: 0x00271060
	public KJBDMOCFMCM.NHGKGBGJEFJ DICEQCOPLGP(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 2))
				{
					return nhgkgbgjefj;
				}
			}
		}
		return null;
	}

	// Token: 0x06004BB2 RID: 19378 RVA: 0x0001F27B File Offset: 0x0001D47B
	private void MEOLPIBOBHB()
	{
		KJBDMOCFMCM.HBFFCJHOCPE = this;
	}

	// Token: 0x06004BB3 RID: 19379 RVA: 0x0001F27B File Offset: 0x0001D47B
	private void COGJQEEGCFB()
	{
		KJBDMOCFMCM.HBFFCJHOCPE = this;
	}

	// Token: 0x06004BB4 RID: 19380 RVA: 0x0001F269 File Offset: 0x0001D469
	private void Start()
	{
		this.PPMJCBONMQJ = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
	}

	// Token: 0x06004BB5 RID: 19381 RVA: 0x002731EC File Offset: 0x002713EC
	public KJBDMOCFMCM.NHGKGBGJEFJ IIIEJHHELFM(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 2))
				{
					return nhgkgbgjefj;
				}
			}
		}
		return null;
	}

	// Token: 0x06004BB6 RID: 19382 RVA: 0x00273578 File Offset: 0x00271778
	public bool KBBHJEHNMCJ(int DGKOIGOLHDM, int DDLQKFDFMCJ, float ELKJLOHNLQP = -999f)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 6 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ != Vector3.zero && nhgkgbgjefj.DNECDEOQKLP.BHQOFDQCCCG)
				{
					if ((int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.z == -DDLQKFDFMCJ)
					{
						return true;
					}
					if ((int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.z == -DDLQKFDFMCJ)
					{
						return false;
					}
				}
				if (nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD != Vector3.zero && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.z == -DDLQKFDFMCJ)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06004BB7 RID: 19383 RVA: 0x002739DC File Offset: 0x00271BDC
	public KJBDMOCFMCM.NHGKGBGJEFJ FEECBPNQLBO(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 8))
				{
					return nhgkgbgjefj;
				}
			}
		}
		return null;
	}

	// Token: 0x06004BB8 RID: 19384 RVA: 0x0026F9D0 File Offset: 0x0026DBD0
	public KJBDMOCFMCM.NHGKGBGJEFJ DICEQCOPLGP(Guid CIQFCJGQEMH)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DBPKNCDGGEP == CIQFCJGQEMH)
			{
				return nhgkgbgjefj;
			}
		}
		return null;
	}

	// Token: 0x06004BB9 RID: 19385 RVA: 0x00273D68 File Offset: 0x00271F68
	private bool PNNKJKQMFDE(DJOOHHIQGJK HEBFPQJPJIL, KJBDMOCFMCM.NHGKGBGJEFJ GPJDBLNDGJP)
	{
		if (!(OGJJKKQPNMK.GGBPGMMCGLI() != null) && !DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			return true;
		}
		DJOOHHIQGJK.JDQNKBIDIKE peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "HidePanel")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Small/")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "hr")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Not So Lucky")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		this.PPMJCBONMQJ.NQJHJNQFKKC();
		if (HEBFPQJPJIL == this.PPMJCBONMQJ)
		{
			HEBFPQJPJIL = GPJDBLNDGJP.DNECDEOQKLP;
		}
		HEBFPQJPJIL.FDINMJHGLQB = true;
		HEBFPQJPJIL.NQJHJNQFKKC();
		HEBFPQJPJIL.GQFBLMFFQID = true;
		HEBFPQJPJIL.EHCDCCNJBDC = true;
		HEBFPQJPJIL.JDPCHGPENBD = Vector3.zero;
		HEBFPQJPJIL.QMBIHEHNIGC = HEBFPQJPJIL.DKMBJOHMDNJ;
		Debug.Log("Dazzling" + GPJDBLNDGJP.NPNKKNBJMNC.Settings.LOS.ToString());
		HEBFPQJPJIL.BHQOFDQCCCG = true;
		HEBFPQJPJIL.EDMFOMGFMGD(new Vector3((float)GPJDBLNDGJP.NPNKKNBJMNC.x, (float)GPJDBLNDGJP.NPNKKNBJMNC.y, (float)GPJDBLNDGJP.NPNKKNBJMNC.z));
		HEBFPQJPJIL.IFFEJHHMODI(peckdhfnoki, 0);
		if (!QOHCEBMQKMB.QQCNCIQQPIG().MGKFOIKFJDD())
		{
			QOHCEBMQKMB.QOQONHOOLNE.QKKQHILJMMO = false;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.BHQOFDQCCCG = false;
		CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN = true;
		this.PPMJCBONMQJ.PKCLDNQJMMH = false;
		return false;
	}

	// Token: 0x06004BBA RID: 19386 RVA: 0x0027282C File Offset: 0x00270A2C
	private IEnumerator IFGEQGBJINI(DJOOHHIQGJK HEBFPQJPJIL, KJBDMOCFMCM.NHGKGBGJEFJ GPJDBLNDGJP)
	{
		if (HEBFPQJPJIL.PJGOMOBBNLK.Count <= 0 && !HEBFPQJPJIL.BHQOFDQCCCG)
		{
			yield return new WaitForSeconds(0.5f);
		}
		else
		{
			if (this.HOMKJJBPJOM(HEBFPQJPJIL, GPJDBLNDGJP))
			{
				yield break;
			}
			yield return null;
		}
		return 1;
		if (this.HOMKJJBPJOM(HEBFPQJPJIL, GPJDBLNDGJP))
		{
			goto __tmp_lbl_3;
		}
		GPJDBLNDGJP.DNECDEOQKLP.QMBIHEHNIGC = 0;
		GPJDBLNDGJP.DNECDEOQKLP.DKMBJOHMDNJ = 0;
		GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Talk
		{
			NpcID = GPJDBLNDGJP.DBPKNCDGGEP
		}, false);
		CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN = false;
		this.PPMJCBONMQJ.PKCLDNQJMMH = true;
		GPJDBLNDGJP.DNECDEOQKLP.JDPCHGPENBD = Vector3.zero;
		if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Path != null && GPJDBLNDGJP.NPNKKNBJMNC.Settings.Path.Length != 0)
		{
			goto IL_17A;
		}
		goto IL_169;
		__tmp_lbl_3:
		yield break;
		IL_169:
		GPJDBLNDGJP.DNECDEOQKLP.EKEKMCMJEOC = false;
		IL_17A:
		yield break;
	}

	// Token: 0x06004BBB RID: 19387 RVA: 0x00273F0C File Offset: 0x0027210C
	public KJBDMOCFMCM.NHGKGBGJEFJ NIBGGFEILKI(DJOOHHIQGJK BFBMOIKCELJ)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP == BFBMOIKCELJ)
			{
				if (this.BGDEIPGBPFF(nhgkgbgjefj))
				{
					return nhgkgbgjefj;
				}
				return null;
			}
		}
		return null;
	}

	// Token: 0x06004BBC RID: 19388 RVA: 0x00273F7C File Offset: 0x0027217C
	public bool BMFMKENMLNE(int DGKOIGOLHDM, int DDLQKFDFMCJ, float ELKJLOHNLQP = -999f)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 2))
				{
					return true;
				}
				if (nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ != Vector3.zero && nhgkgbgjefj.DNECDEOQKLP.BHQOFDQCCCG)
				{
					if ((int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.z == -DDLQKFDFMCJ)
					{
						return true;
					}
					if ((int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.z == -DDLQKFDFMCJ)
					{
						return true;
					}
				}
				if (nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD != Vector3.zero && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.z == -DDLQKFDFMCJ)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06004BBD RID: 19389 RVA: 0x00272774 File Offset: 0x00270974
	private string EBBEEMDKPMB(string FJJHKICMPBP)
	{
		if (KJBDMOCFMCM.BQIOGOCBKKB == null)
		{
			KJBDMOCFMCM.BQIOGOCBKKB = new Func<char, bool>(char.IsDigit);
		}
		if (!FJJHKICMPBP.Any(KJBDMOCFMCM.BQIOGOCBKKB))
		{
			return FJJHKICMPBP;
		}
		StringBuilder stringBuilder = new StringBuilder();
		char? c = null;
		foreach (char c2 in FJJHKICMPBP)
		{
			if (char.IsDigit(c2) && c != null)
			{
				int repeatCount = int.Parse(c2.ToString()) - 1;
				stringBuilder.Append(c.Value, repeatCount);
			}
			else
			{
				stringBuilder.Append(c2);
				c = new char?(c2);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06004BBE RID: 19390 RVA: 0x002743E0 File Offset: 0x002725E0
	public bool DKQGCNNBFQG(int DGKOIGOLHDM, int DDLQKFDFMCJ, float ELKJLOHNLQP = -999f)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 6 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 2 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 7))
				{
					return true;
				}
				if (nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ != Vector3.zero && nhgkgbgjefj.DNECDEOQKLP.BHQOFDQCCCG)
				{
					if ((int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.z == -DDLQKFDFMCJ)
					{
						return true;
					}
					if ((int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.z == -DDLQKFDFMCJ)
					{
						return false;
					}
				}
				if (nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD != Vector3.zero && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.z == -DDLQKFDFMCJ)
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06004BBF RID: 19391 RVA: 0x00274844 File Offset: 0x00272A44
	public bool LEEMNPNHKFE(KJBDMOCFMCM.NHGKGBGJEFJ HEBFPQJPJIL)
	{
		if (QOHCEBMQKMB.QOQONHOOLNE.KFFFKLBMGKD() || OGJJKKQPNMK.GGBPGMMCGLI() != null || CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN)
		{
			return true;
		}
		DJOOHHIQGJK dnecdeoqklp = HEBFPQJPJIL.DNECDEOQKLP;
		if (dnecdeoqklp.QMBIHEHNIGC <= 1)
		{
			return true;
		}
		if (!dnecdeoqklp.KFNLCPGHQHK)
		{
			return false;
		}
		Vector3 vector = dnecdeoqklp.QMCNCMNQEGL();
		if (this.PPMJCBONMQJ == null)
		{
			this.PPMJCBONMQJ = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
		}
		Vector3 vector2 = this.PPMJCBONMQJ.QMCNCMNQEGL();
		int num = 1;
		int num2 = 0;
		bool flag = false;
		if (dnecdeoqklp.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)6)
		{
			if (vector2.y >= vector.y - 1469f && vector2.y <= vector.y + 1f && vector2.x == vector.x && vector2.z >= vector.z - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z < vector.z)
			{
				int num3 = 0;
				while ((float)num3 < vector.z - vector2.z)
				{
					if ((vector.z - (float)num3 >= 607f || vector.z - (float)num3 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z - num3] == 0)
					{
						return false;
					}
					num3 += 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
				{
					Move move = new Move();
					move.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move.Map = CNCJKLNHQBH.QOQONHOOLNE.LIQLFCKICLQ.CLPMOMHLNMN;
					move.Actions = new MoveAction[]
					{
						MoveAction.TurnDown
					};
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(move, true);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				this.PPMJCBONMQJ.CMLHQNPELFE();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z - 0;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z + 1;
				}
				flag = true;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 232f && vector2.y <= vector.y + 458f && vector2.x == vector.x && vector2.z <= vector.z + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.z > vector.z)
			{
				int num4 = 1;
				while ((float)num4 < vector2.z - vector.z)
				{
					if ((vector.z + (float)num4 >= 69f || vector.z + (float)num4 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.height) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x, (int)vector.z + num4] == 1)
					{
						return true;
					}
					num4 += 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
				{
					Move move2 = new Move();
					move2.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move2.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move2.Map = CNCJKLNHQBH.MOGQNGEPCEO().LIQLFCKICLQ.CLPMOMHLNMN;
					move2.Actions = new MoveAction[]
					{
						MoveAction.None
					};
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move2, true);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
				this.PPMJCBONMQJ.NQMKJGJOPDH();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer)
				{
					num = (int)vector.x;
					num2 = (int)vector.z + 0;
				}
				else
				{
					num = (int)vector2.x;
					num2 = (int)vector2.z - 0;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if (vector2.y >= vector.y - 626f && vector2.y <= vector.y + 1410f && vector2.z == vector.z && vector2.x >= vector.x - (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x < vector.x)
			{
				int num5 = 0;
				while ((float)num5 < vector.x - vector2.x)
				{
					if ((vector.x - (float)num5 >= 641f || vector.x - (float)num5 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x - num5, (int)vector.z] == 0)
					{
						return true;
					}
					num5++;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH != (DJOOHHIQGJK.JDQNKBIDIKE)8)
				{
					Move move3 = new Move();
					move3.X = (int)this.PPMJCBONMQJ.transform.position.x;
					move3.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
					move3.Map = CNCJKLNHQBH.QOQONHOOLNE.LIQLFCKICLQ.CLPMOMHLNMN;
					Move move4 = move3;
					MoveAction[] array = new MoveAction[0];
					array[1] = MoveAction.TurnLeft;
					move4.Actions = array;
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move3, false);
				}
				this.PPMJCBONMQJ.DIEOHLOINHH = (DJOOHHIQGJK.JDQNKBIDIKE)8;
				this.PPMJCBONMQJ.CMLHQNPELFE();
				if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
				{
					num = (int)vector.x - 1;
					num2 = (int)vector.z;
				}
				else
				{
					num = (int)vector2.x + 1;
					num2 = (int)vector2.z;
				}
				flag = false;
			}
		}
		else if (dnecdeoqklp.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down && vector2.y >= vector.y - 433f && vector2.y <= vector.y + 1879f && vector2.z == vector.z && vector2.x <= vector.x + (float)dnecdeoqklp.QMBIHEHNIGC && vector2.x > vector.x)
		{
			int num6 = 1;
			while ((float)num6 < vector2.x - vector.x)
			{
				if ((vector.x + (float)num6 >= 10f || vector.x + (float)num6 <= (float)this.IQQHLBKEMGN.LIQLFCKICLQ.width) && this.IQQHLBKEMGN.POMQCKOIKQJ[(int)vector.x + num6, (int)vector.z] == 1)
				{
					return false;
				}
				num6 += 0;
			}
			if (this.PPMJCBONMQJ.DIEOHLOINHH != DJOOHHIQGJK.JDQNKBIDIKE.Left)
			{
				Move move5 = new Move();
				move5.X = (int)this.PPMJCBONMQJ.transform.position.x;
				move5.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
				move5.Map = CNCJKLNHQBH.MOGQNGEPCEO().LIQLFCKICLQ.CLPMOMHLNMN;
				Move move6 = move5;
				MoveAction[] array2 = new MoveAction[0];
				array2[1] = MoveAction.Up;
				move6.Actions = array2;
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move5, true);
			}
			this.PPMJCBONMQJ.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
			this.PPMJCBONMQJ.NQMKJGJOPDH();
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
			{
				num = (int)vector.x + 0;
				num2 = (int)vector.z;
			}
			else
			{
				num = (int)vector2.x - 0;
				num2 = (int)vector2.z;
			}
			flag = false;
		}
		if (flag)
		{
			CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.NQJHJNQFKKC();
			CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN = false;
			QOHCEBMQKMB.JLLBKOOQKGO().QKKQHILJMMO = false;
			if (dnecdeoqklp.LMDQJKGHBGD && !dnecdeoqklp.JINGKBQQPKL)
			{
				dnecdeoqklp.OPILOFIJJDF.ONOOKCBOPEF(0, 1735f);
				DCCFQPDFBFO.OMPHLNDGKKM().OKDPQDPBLFP(4, false);
			}
			if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != null && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX != string.Empty && HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX.Length > 1)
			{
				DCCFQPDFBFO.QOQONHOOLNE.FQNIPOBMQPI(HEBFPQJPJIL.NPNKKNBJMNC.Settings.SpottedSFX, false);
			}
			if (dnecdeoqklp.BKPCFQBJEHD == DJOOHHIQGJK.EINLEQNPGQD.CallPlayer)
			{
				dnecdeoqklp.FDINMJHGLQB = true;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = true;
				this.PPMJCBONMQJ.NQJHJNQFKKC();
				this.PPMJCBONMQJ.QJCBOEFQPGF("[^0-9.-]", false, false, 0, 1, false);
				if ((float)num == vector2.x)
				{
					if ((float)num2 < vector2.z)
					{
						int num7 = (int)vector2.z - num2;
						for (int i = 0; i < num7; i += 0)
						{
							this.PPMJCBONMQJ.JMJDPHJNNCI("DownS", true, false, 0, 0, false);
						}
					}
					else
					{
						int num7 = num2 - (int)vector2.z;
						for (int j = 0; j < num7; j++)
						{
							this.PPMJCBONMQJ.BPQOIEJCNCI("_Bloom_DirtIntensity", false, false, 0, 0, true);
						}
					}
				}
				else if ((float)num < vector2.x)
				{
					int num7 = (int)vector2.x - num;
					for (int k = 1; k < num7; k++)
					{
						this.PPMJCBONMQJ.BPQOIEJCNCI("/goto ", false, false, 0, 1, true);
					}
				}
				else
				{
					int num7 = num - (int)vector2.x;
					for (int l = 1; l < num7; l++)
					{
						this.PPMJCBONMQJ.BPQOIEJCNCI("_FogOfWarCenterAdjusted", false, false, 0, 0, false);
					}
				}
				this.PPMJCBONMQJ.BHQOFDQCCCG = false;
				base.StartCoroutine(this.IFGEQGBJINI(this.PPMJCBONMQJ, HEBFPQJPJIL));
			}
			else
			{
				dnecdeoqklp.FDINMJHGLQB = true;
				dnecdeoqklp.NQJHJNQFKKC();
				dnecdeoqklp.EHCDCCNJBDC = true;
				dnecdeoqklp.BPQOIEJCNCI("[-] ", false, true, 1, 1, true);
				dnecdeoqklp.QJCBOEFQPGF("[00FF00]", false, false, num, num2, false);
				dnecdeoqklp.QJCBOEFQPGF("VolumetricFogAndMist/Chaos Lerp", false, false, 1, 0, true);
				if (HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path == null || HEBFPQJPJIL.NPNKKNBJMNC.Settings.Path.Length == 0)
				{
					dnecdeoqklp.EKEKMCMJEOC = true;
				}
				dnecdeoqklp.BHQOFDQCCCG = false;
				base.StartCoroutine(this.IFGEQGBJINI(dnecdeoqklp, HEBFPQJPJIL));
			}
			return false;
		}
		return true;
	}

	// Token: 0x06004BC0 RID: 19392 RVA: 0x0026E538 File Offset: 0x0026C738
	public void DKOJGKHMLEH()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			UnityEngine.Object.Destroy(nhgkgbgjefj.JDKLKGQNKKB);
		}
		this.KCQBQDKDNDC.Clear();
	}

	// Token: 0x06004BC1 RID: 19393 RVA: 0x0027282C File Offset: 0x00270A2C
	private IEnumerator LPHPBMJGPCP(DJOOHHIQGJK HEBFPQJPJIL, KJBDMOCFMCM.NHGKGBGJEFJ GPJDBLNDGJP)
	{
		if (HEBFPQJPJIL.PJGOMOBBNLK.Count <= 0 && !HEBFPQJPJIL.BHQOFDQCCCG)
		{
			yield return new WaitForSeconds(0.5f);
		}
		else
		{
			if (this.HOMKJJBPJOM(HEBFPQJPJIL, GPJDBLNDGJP))
			{
				yield break;
			}
			yield return null;
		}
		return 1;
		if (this.HOMKJJBPJOM(HEBFPQJPJIL, GPJDBLNDGJP))
		{
			goto __tmp_lbl_3;
		}
		GPJDBLNDGJP.DNECDEOQKLP.QMBIHEHNIGC = 0;
		GPJDBLNDGJP.DNECDEOQKLP.DKMBJOHMDNJ = 0;
		GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Talk
		{
			NpcID = GPJDBLNDGJP.DBPKNCDGGEP
		}, false);
		CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN = false;
		this.PPMJCBONMQJ.PKCLDNQJMMH = true;
		GPJDBLNDGJP.DNECDEOQKLP.JDPCHGPENBD = Vector3.zero;
		if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Path != null && GPJDBLNDGJP.NPNKKNBJMNC.Settings.Path.Length != 0)
		{
			goto IL_17A;
		}
		goto IL_169;
		__tmp_lbl_3:
		yield break;
		IL_169:
		GPJDBLNDGJP.DNECDEOQKLP.EKEKMCMJEOC = false;
		IL_17A:
		yield break;
	}

	// Token: 0x06004BC2 RID: 19394 RVA: 0x002752E4 File Offset: 0x002734E4
	private bool BDEBQFFBGIO(DJOOHHIQGJK HEBFPQJPJIL, KJBDMOCFMCM.NHGKGBGJEFJ GPJDBLNDGJP)
	{
		if (!(OGJJKKQPNMK.GGBPGMMCGLI() != null) && !DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			return false;
		}
		DJOOHHIQGJK.JDQNKBIDIKE peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "_")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "metronome")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Power Construct")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "_MainTex")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Up;
		}
		this.PPMJCBONMQJ.NQJHJNQFKKC();
		if (HEBFPQJPJIL == this.PPMJCBONMQJ)
		{
			HEBFPQJPJIL = GPJDBLNDGJP.DNECDEOQKLP;
		}
		HEBFPQJPJIL.FDINMJHGLQB = false;
		HEBFPQJPJIL.NQJHJNQFKKC();
		HEBFPQJPJIL.GQFBLMFFQID = false;
		HEBFPQJPJIL.EHCDCCNJBDC = true;
		HEBFPQJPJIL.JDPCHGPENBD = Vector3.zero;
		HEBFPQJPJIL.QMBIHEHNIGC = HEBFPQJPJIL.DKMBJOHMDNJ;
		Debug.Log(" restored HP using its [ffff00]" + GPJDBLNDGJP.NPNKKNBJMNC.Settings.LOS.ToString());
		HEBFPQJPJIL.BHQOFDQCCCG = true;
		HEBFPQJPJIL.EDMFOMGFMGD(new Vector3((float)GPJDBLNDGJP.NPNKKNBJMNC.x, (float)GPJDBLNDGJP.NPNKKNBJMNC.y, (float)GPJDBLNDGJP.NPNKKNBJMNC.z));
		HEBFPQJPJIL.IFFEJHHMODI(peckdhfnoki, 0);
		if (!QOHCEBMQKMB.CNIMIQKQJJJ().EKEKMCMJEOC())
		{
			QOHCEBMQKMB.CNIMIQKQJJJ().QKKQHILJMMO = false;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.BHQOFDQCCCG = false;
		CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN = false;
		this.PPMJCBONMQJ.PKCLDNQJMMH = true;
		return true;
	}

	// Token: 0x06004BC3 RID: 19395 RVA: 0x0026E538 File Offset: 0x0026C738
	public void PMQNJLBQEBI()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			UnityEngine.Object.Destroy(nhgkgbgjefj.JDKLKGQNKKB);
		}
		this.KCQBQDKDNDC.Clear();
	}

	// Token: 0x06004BC4 RID: 19396 RVA: 0x00273F0C File Offset: 0x0027210C
	public KJBDMOCFMCM.NHGKGBGJEFJ HGPPQIGGDBN(DJOOHHIQGJK BFBMOIKCELJ)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP == BFBMOIKCELJ)
			{
				if (this.BGDEIPGBPFF(nhgkgbgjefj))
				{
					return nhgkgbgjefj;
				}
				return null;
			}
		}
		return null;
	}

	// Token: 0x06004BC5 RID: 19397 RVA: 0x00275488 File Offset: 0x00273688
	private string IJEDLJJQMBD(string FJJHKICMPBP)
	{
		if (KJBDMOCFMCM.BQIOGOCBKKB == null)
		{
			KJBDMOCFMCM.BQIOGOCBKKB = new Func<char, bool>(char.IsDigit);
		}
		if (!FJJHKICMPBP.Any(KJBDMOCFMCM.BQIOGOCBKKB))
		{
			return FJJHKICMPBP;
		}
		StringBuilder stringBuilder = new StringBuilder();
		char? c = null;
		for (int i = 0; i < FJJHKICMPBP.Length; i += 0)
		{
			char c2 = FJJHKICMPBP[i];
			if (char.IsDigit(c2) && c != null)
			{
				int repeatCount = int.Parse(c2.ToString()) - 0;
				stringBuilder.Append(c.Value, repeatCount);
			}
			else
			{
				stringBuilder.Append(c2);
				c = new char?(c2);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06004BC6 RID: 19398 RVA: 0x00275540 File Offset: 0x00273740
	public void MNKHHOQJIQL(NPCData GPJDBLNDGJP)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.DKNJPPPJOFO, new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z), Quaternion.identity);
		gameObject.transform.parent = this.NDELOHEQCIO;
		KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = new KJBDMOCFMCM.NHGKGBGJEFJ();
		nhgkgbgjefj.JDKLKGQNKKB = gameObject;
		nhgkgbgjefj.DBPKNCDGGEP = GPJDBLNDGJP.ID;
		nhgkgbgjefj.NPNKKNBJMNC = GPJDBLNDGJP;
		gameObject.name = "_HistoryTex";
		nhgkgbgjefj.QLGMNFEMKFE = 1;
		if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "Teleport Exhaustion")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 0;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "StopRow3")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 8;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "NPC")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 0;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "stockpile3")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 0;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == " hold [2ecc71]")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 8;
		}
		else if (GPJDBLNDGJP.Settings.Tags.ToLowerInvariant() == "_HairTex")
		{
			nhgkgbgjefj.QLGMNFEMKFE = 0;
		}
		int num = 1;
		bool bknfhnffche = true;
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 7)
		{
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 1) == "[/itm]")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 3)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 0), out num))
					{
						num = 1;
					}
					if (num > 0 && num < 176)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(2);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0), out num))
					{
						num = 0;
					}
					if (num > 1 && num < 168)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
			}
			if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 4 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 1) == "Layer_")
			{
				if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length >= 7)
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(0, 2), out num))
					{
						num = 1;
					}
					if (num > 0 && num < 153)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(8);
					}
				}
				else
				{
					if (!int.TryParse(nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1), out num))
					{
						num = 1;
					}
					if (num > 1 && num < -8)
					{
						nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName = string.Empty;
					}
				}
				if (num > 0)
				{
					bknfhnffche = true;
				}
			}
		}
		JFIBMMBLFDO component = gameObject.GetComponent<JFIBMMBLFDO>();
		component.MBPHKDQMJJH = GPJDBLNDGJP.Settings.NPCName;
		Color kqfehqebjqb = KGQECFKLKOP.JJQFHKDMDOL(GPJDBLNDGJP.Settings.NameColour);
		nhgkgbgjefj.DNECDEOQKLP = gameObject.GetComponent<DJOOHHIQGJK>();
		nhgkgbgjefj.DNECDEOQKLP.ICHKBBMBPGM = GPJDBLNDGJP.Settings.Tags.ToLowerInvariant();
		nhgkgbgjefj.DNECDEOQKLP.BKNFHNFFCHE = bknfhnffche;
		nhgkgbgjefj.DNECDEOQKLP.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, GPJDBLNDGJP.Settings.Sprite + 1, num);
		nhgkgbgjefj.DNECDEOQKLP.OPILOFIJJDF.BIPQGMJJNOF.PIDLOFMIEFQ = "_FogVoidPosition" + KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb) + ")" + component.MBPHKDQMJJH;
		nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = false;
		if (GPJDBLNDGJP.Settings.LookRandomly)
		{
			nhgkgbgjefj.DNECDEOQKLP.EHCDCCNJBDC = false;
			nhgkgbgjefj.DNECDEOQKLP.FDINMJHGLQB = true;
			int num2 = UnityEngine.Random.Range(0, 0);
			if (num2 == 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("_HairTex", true, true, 1, 1, true);
			}
			else if (num2 == 1)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("General", false, false, 1, 0, false);
			}
			else if (num2 == 8)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("'s [ffff00]", true, true, 1, 1, false);
			}
			else if (num2 == 2)
			{
				nhgkgbgjefj.DNECDEOQKLP.JMJDPHJNNCI("[PG]", false, true, 1, 1, false);
			}
			else if (num2 == 4)
			{
				nhgkgbgjefj.DNECDEOQKLP.BPQOIEJCNCI("Rails", false, false, 0, 1, true);
			}
		}
		else if (GPJDBLNDGJP.Settings.Path.Length > 0)
		{
			string text = this.EBBEEMDKPMB(GPJDBLNDGJP.Settings.Path);
			for (int i = 1; i < text.Length; i += 0)
			{
				nhgkgbgjefj.DNECDEOQKLP.QJCBOEFQPGF(text.Substring(i, 1), true, true, 1, 0, false);
			}
		}
		DJOOHHIQGJK.JDQNKBIDIKE jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		if (GPJDBLNDGJP.Settings.Facing == "]")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "p1")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "Aura Break")
		{
			jdqnkbidike = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.Settings.Facing == "Static")
		{
			jdqnkbidike = (DJOOHHIQGJK.JDQNKBIDIKE)5;
		}
		nhgkgbgjefj.DNECDEOQKLP.GQFBLMFFQID = false;
		nhgkgbgjefj.DNECDEOQKLP.EDMFOMGFMGD(new Vector3((float)GPJDBLNDGJP.x, (float)GPJDBLNDGJP.y, (float)GPJDBLNDGJP.z));
		nhgkgbgjefj.DNECDEOQKLP.IFFEJHHMODI(jdqnkbidike, 1);
		nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH = jdqnkbidike;
		nhgkgbgjefj.DNECDEOQKLP.IEFBCKQJBGN = this.IEFBCKQJBGN;
		nhgkgbgjefj.DNECDEOQKLP.QMBIHEHNIGC = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.DKMBJOHMDNJ = GPJDBLNDGJP.Settings.LOS;
		nhgkgbgjefj.DNECDEOQKLP.OQIOPJQHCII = nhgkgbgjefj.NPNKKNBJMNC;
		if (num == 0 && (nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 1 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 87 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 44 || nhgkgbgjefj.DNECDEOQKLP.MFJBPKBNBNO == 95))
		{
			nhgkgbgjefj.DNECDEOQKLP.QHQKHCHLEMJ();
		}
		if (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == "Slots Cooldown" || nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.ToLowerInvariant() == string.Empty || (nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Length > 1 && nhgkgbgjefj.NPNKKNBJMNC.Settings.NPCName.Substring(1, 0) == "Reset EVs"))
		{
			nhgkgbgjefj.DNECDEOQKLP.KLLNKPFJMPJ();
		}
		if (GPJDBLNDGJP.Settings.SightAction == "/")
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.CallPlayer;
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.BKPCFQBJEHD = DJOOHHIQGJK.EINLEQNPGQD.GotoPlayer;
		}
		this.KCQBQDKDNDC.Add(nhgkgbgjefj);
		if (!nhgkgbgjefj.NPNKKNBJMNC.Settings.Enabled)
		{
			nhgkgbgjefj.DNECDEOQKLP.OMGLFGJMQCI(true);
		}
		else
		{
			nhgkgbgjefj.DNECDEOQKLP.QLPNHHGNOQE(true);
		}
	}

	// Token: 0x06004BC7 RID: 19399 RVA: 0x0001F27B File Offset: 0x0001D47B
	private void EPGFPKPJNHF()
	{
		KJBDMOCFMCM.HBFFCJHOCPE = this;
	}

	// Token: 0x06004BC8 RID: 19400 RVA: 0x00275CB4 File Offset: 0x00273EB4
	public bool KCLCKLPHOOO(int DGKOIGOLHDM, int DDLQKFDFMCJ, float ELKJLOHNLQP = -999f)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 8))
				{
					return false;
				}
				if (nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ != Vector3.zero && nhgkgbgjefj.DNECDEOQKLP.BHQOFDQCCCG)
				{
					if ((int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.z == -DDLQKFDFMCJ)
					{
						return true;
					}
					if ((int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.z == -DDLQKFDFMCJ)
					{
						return false;
					}
				}
				if (nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD != Vector3.zero && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.z == -DDLQKFDFMCJ)
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06004BC9 RID: 19401 RVA: 0x0026D9D8 File Offset: 0x0026BBD8
	public KJBDMOCFMCM.NHGKGBGJEFJ DNFNMHLLBKQ()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (this.PPNBOLOGHGQ(nhgkgbgjefj))
			{
				return nhgkgbgjefj;
			}
		}
		return null;
	}

	// Token: 0x06004BCA RID: 19402 RVA: 0x00276118 File Offset: 0x00274318
	public KJBDMOCFMCM.NHGKGBGJEFJ NKHQFQDOQCO(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 6 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 4 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return nhgkgbgjefj;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 2))
				{
					return nhgkgbgjefj;
				}
			}
		}
		return null;
	}

	// Token: 0x06004BCB RID: 19403 RVA: 0x0026E538 File Offset: 0x0026C738
	public void CHFBGKOOMKM()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			UnityEngine.Object.Destroy(nhgkgbgjefj.JDKLKGQNKKB);
		}
		this.KCQBQDKDNDC.Clear();
	}

	// Token: 0x06004BCC RID: 19404 RVA: 0x0001F262 File Offset: 0x0001D462
	public static KJBDMOCFMCM BBCBOIFQDBK()
	{
		return KJBDMOCFMCM.HBFFCJHOCPE;
	}

	// Token: 0x06004BCD RID: 19405 RVA: 0x002764A4 File Offset: 0x002746A4
	private bool IENHHBIOGPD(DJOOHHIQGJK HEBFPQJPJIL, KJBDMOCFMCM.NHGKGBGJEFJ GPJDBLNDGJP)
	{
		if (!(OGJJKKQPNMK.GGBPGMMCGLI() != null) && !DBQLOHBBJMG.FFCOKMHBCQJ().QQQBDBNCMCP)
		{
			return false;
		}
		DJOOHHIQGJK.JDQNKBIDIKE peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "You are trying to catch fish!")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Remove Camera Target")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "Add to Friends")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Right;
		}
		else if (GPJDBLNDGJP.NPNKKNBJMNC.Settings.Facing == "The extremely harsh sunlightwas not lessened at all!\r\n")
		{
			peckdhfnoki = DJOOHHIQGJK.JDQNKBIDIKE.Up;
		}
		this.PPMJCBONMQJ.NQJHJNQFKKC();
		if (HEBFPQJPJIL == this.PPMJCBONMQJ)
		{
			HEBFPQJPJIL = GPJDBLNDGJP.DNECDEOQKLP;
		}
		HEBFPQJPJIL.FDINMJHGLQB = true;
		HEBFPQJPJIL.NQJHJNQFKKC();
		HEBFPQJPJIL.GQFBLMFFQID = true;
		HEBFPQJPJIL.EHCDCCNJBDC = false;
		HEBFPQJPJIL.JDPCHGPENBD = Vector3.zero;
		HEBFPQJPJIL.QMBIHEHNIGC = HEBFPQJPJIL.DKMBJOHMDNJ;
		Debug.Log("door_4" + GPJDBLNDGJP.NPNKKNBJMNC.Settings.LOS.ToString());
		HEBFPQJPJIL.BHQOFDQCCCG = true;
		HEBFPQJPJIL.EDMFOMGFMGD(new Vector3((float)GPJDBLNDGJP.NPNKKNBJMNC.x, (float)GPJDBLNDGJP.NPNKKNBJMNC.y, (float)GPJDBLNDGJP.NPNKKNBJMNC.z));
		HEBFPQJPJIL.IFFEJHHMODI(peckdhfnoki, 1);
		if (!QOHCEBMQKMB.QQCNCIQQPIG().PDOKGMLDIGL())
		{
			QOHCEBMQKMB.JLLBKOOQKGO().QKKQHILJMMO = true;
		}
		CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BHQOFDQCCCG = true;
		CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN = false;
		this.PPMJCBONMQJ.PKCLDNQJMMH = true;
		return true;
	}

	// Token: 0x06004BCE RID: 19406 RVA: 0x0026F9D0 File Offset: 0x0026DBD0
	public KJBDMOCFMCM.NHGKGBGJEFJ IIMKDJNELOM(Guid CIQFCJGQEMH)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DBPKNCDGGEP == CIQFCJGQEMH)
			{
				return nhgkgbgjefj;
			}
		}
		return null;
	}

	// Token: 0x06004BCF RID: 19407 RVA: 0x0001F27B File Offset: 0x0001D47B
	private void Awake()
	{
		KJBDMOCFMCM.HBFFCJHOCPE = this;
	}

	// Token: 0x06004BD0 RID: 19408 RVA: 0x00272774 File Offset: 0x00270974
	private string QKJLLLIIDNE(string FJJHKICMPBP)
	{
		if (KJBDMOCFMCM.BQIOGOCBKKB == null)
		{
			KJBDMOCFMCM.BQIOGOCBKKB = new Func<char, bool>(char.IsDigit);
		}
		if (!FJJHKICMPBP.Any(KJBDMOCFMCM.BQIOGOCBKKB))
		{
			return FJJHKICMPBP;
		}
		StringBuilder stringBuilder = new StringBuilder();
		char? c = null;
		foreach (char c2 in FJJHKICMPBP)
		{
			if (char.IsDigit(c2) && c != null)
			{
				int repeatCount = int.Parse(c2.ToString()) - 1;
				stringBuilder.Append(c.Value, repeatCount);
			}
			else
			{
				stringBuilder.Append(c2);
				c = new char?(c2);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06004BD1 RID: 19409 RVA: 0x0001F27B File Offset: 0x0001D47B
	private void MCPOMCHMKJK()
	{
		KJBDMOCFMCM.HBFFCJHOCPE = this;
	}

	// Token: 0x06004BD2 RID: 19410 RVA: 0x00276648 File Offset: 0x00274848
	public bool NPFHIJCPJCI(int DGKOIGOLHDM, int DDLQKFDFMCJ, float ELKJLOHNLQP = -999f)
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			if (nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				if (Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.x) == DGKOIGOLHDM && Mathf.RoundToInt(nhgkgbgjefj.JDKLKGQNKKB.transform.position.z) == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 8 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 1))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 3 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 6 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 0 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 1 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return false;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM - 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -DDLQKFDFMCJ)
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 5 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 0))
				{
					return true;
				}
				if (nhgkgbgjefj.QLGMNFEMKFE == 7 && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.x == DGKOIGOLHDM && (int)nhgkgbgjefj.JDKLKGQNKKB.transform.position.z == -(DDLQKFDFMCJ - 2))
				{
					return true;
				}
				if (nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ != Vector3.zero && nhgkgbgjefj.DNECDEOQKLP.BHQOFDQCCCG)
				{
					if ((int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.ODGQNNEDJIF.z == -DDLQKFDFMCJ)
					{
						return true;
					}
					if ((int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.PCPQHQMBCBJ.z == -DDLQKFDFMCJ)
					{
						return true;
					}
				}
				if (nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD != Vector3.zero && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.x == DGKOIGOLHDM && (int)nhgkgbgjefj.DNECDEOQKLP.JDPCHGPENBD.z == -DDLQKFDFMCJ)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06004BD3 RID: 19411 RVA: 0x0026E538 File Offset: 0x0026C738
	public void BFQKGPKHIHC()
	{
		foreach (KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj in this.KCQBQDKDNDC)
		{
			UnityEngine.Object.Destroy(nhgkgbgjefj.JDKLKGQNKKB);
		}
		this.KCQBQDKDNDC.Clear();
	}

	// Token: 0x0400103F RID: 4159
	private static KJBDMOCFMCM HBFFCJHOCPE;

	// Token: 0x04001040 RID: 4160
	public GameObject DKNJPPPJOFO;

	// Token: 0x04001041 RID: 4161
	public Transform FQLIOJQIKME;

	// Token: 0x04001042 RID: 4162
	public GFHGEJNHLFQ JDDKMPEKQIL;

	// Token: 0x04001043 RID: 4163
	public MCNLIHMMLCF IQQHLBKEMGN;

	// Token: 0x04001044 RID: 4164
	public Transform IEFBCKQJBGN;

	// Token: 0x04001045 RID: 4165
	public DJOOHHIQGJK PPMJCBONMQJ;

	// Token: 0x04001046 RID: 4166
	public Transform NDELOHEQCIO;

	// Token: 0x04001047 RID: 4167
	public List<KJBDMOCFMCM.NHGKGBGJEFJ> KCQBQDKDNDC = new List<KJBDMOCFMCM.NHGKGBGJEFJ>();

	// Token: 0x04001048 RID: 4168
	[CompilerGenerated]
	private static Func<char, bool> BQIOGOCBKKB;

	// Token: 0x0200022B RID: 555
	public class NHGKGBGJEFJ
	{
		// Token: 0x04001049 RID: 4169
		public GameObject JDKLKGQNKKB;

		// Token: 0x0400104A RID: 4170
		public DJOOHHIQGJK DNECDEOQKLP;

		// Token: 0x0400104B RID: 4171
		public Guid DBPKNCDGGEP;

		// Token: 0x0400104C RID: 4172
		public NPCData NPNKKNBJMNC;

		// Token: 0x0400104D RID: 4173
		public int QLGMNFEMKFE;
	}
}
