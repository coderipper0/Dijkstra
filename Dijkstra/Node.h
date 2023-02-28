#pragma once

using namespace System;
using namespace System::Collections;
using namespace System::Collections::Generic;

public ref class Node {
public:
	String^ name;
	int distance;
	ArrayList^ path;
	Dictionary<Node^, int>^ adjacents;

	Node(String^ name, int distance);
	bool isAdjacent(Node^ node);
	void addAdjacent(Node^ node, int distance);
	void addPath(ArrayList^ newPath);
};