// CreateDLL.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "CreateDLL.h"

int _stdcall test01(int a, int b, int c) {
	return a + b + c;
}

int _stdcall test02(int a, int b) {
	return a - b;
}
