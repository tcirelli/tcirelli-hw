package org.cirelli.thita.college.types;

import java.util.ArrayList;

public interface IAssignment{
    void run();
    void addSection(ISection s);
}

public class Assignment implements IAssignment{
    public void Assignment() {
        ArrayList<ISection> sections = new ArrayList<ISection>();
    }

    void run() {
        for (ISection s : sections) {
            s.run();
        }
    }

    void addSection(ISection s){
        sections.addItem(s);
    }
}
