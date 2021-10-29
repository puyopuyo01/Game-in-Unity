using System.Collections;
using System.Collections.Generic;

namespace Character{
/*回数制限を持つ強化処理に継承させるインタフェース*/
	public interface limit{
		bool Available{
			get;
		}
	}
}
