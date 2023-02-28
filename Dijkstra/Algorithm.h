#pragma once
#include "Node.h"

using namespace System;
using namespace System::Collections::Generic;

public ref class Algorithm
{
private:
	static Node^ getLessEgdeValue(HashSet<Node^>^ uncheckedNodes);
	static void getPath(Node^ node, int value, Node^ predecessor);
public:
	static String^ execute(Node^ start, Node^ end);
};